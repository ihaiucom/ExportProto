using BeardedManStudios.Templating;
using LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

public class JsonExportGM
{
    public static void Export(ProtoManager pm)
    {
        ProtoModuleData server = pm.apiReader.modules.GetValueByKey("test");
        ProtoModuleData client = pm.apiReader.modules.GetValueByKey("ClientGM");

        ExportModule(server, true, Setting.Options.jsonServerGM);
        ExportModule(client, false, Setting.Options.jsonClientGM);
    }


    private static void ExportModule(ProtoModuleData data, bool isReq, string path)
    {
        Dictionary<string, JsonData> preCmdDict = new Dictionary<string, JsonData>();
        JsonData preJD = null;
        if (File.Exists(path))
        {
            preJD = JsonMapper.ToObject(File.ReadAllText(path));
            foreach(JsonData preCmd in preJD)
            {
                preCmdDict.Add(preCmd["name"].ToString(), preCmd);
            }
        }
        
        List<ProtoMessageData> msgs =  data.msgs.Values;

        JsonData jd = new JsonData();
        jd.SetJsonType(JsonType.Array);
        foreach (ProtoMessageData msg in msgs)
        {
            JsonData cmd = new JsonData();
            cmd.SetJsonType(JsonType.Object);
            cmd["cnname"] = msg.cnname;
            cmd["name"] = msg.name;
            JsonData cmdData = new JsonData();
            cmdData.SetJsonType(JsonType.Object);
            Dictionary<string, FieldData> fields;
            if (isReq)
                fields = msg.req.fields;
            else
                fields = msg.res.fields;

            foreach (var kvp in fields)
            {
                FieldData field = kvp.Value;

                JsonData val = null;
                if(preCmdDict.ContainsKey(msg.name)  
                    && preCmdDict[msg.name].ContainsKey("data")
                    && preCmdDict[msg.name]["data"].ContainsKey(field.fieldName))
                {
                    val = preCmdDict[msg.name]["data"][field.fieldName];
                }

                if(val == null)
                {
                    switch (field.tsType)
                    {
                        case "string":
                            val = new JsonData("1");
                            break;
                        case "number":
                            val = new JsonData(1);
                            break;
                        case "boolean":
                            val = new JsonData(true);
                            break;
                        case "string[]":
                            val = new JsonData();
                            val.SetJsonType(JsonType.Array);
                            val.Add("1");
                            break;
                        case "number[]":
                            val = new JsonData();
                            val.SetJsonType(JsonType.Array);
                            val.Add(1);
                            break;
                        case "boolean[]":
                            val = new JsonData();
                            val.SetJsonType(JsonType.Array);
                            val.Add(true);
                            break;
                    }
                }

                cmdData[field.fieldName] = val;
            }
            cmd["data"] = cmdData;

            jd.Add(cmd);
        }


        string json = JsonMapper.ToJson(jd).ConvertJsonString();

        PathHelper.CheckPath(path);
        File.WriteAllText(path, json, Encoding.UTF8);

    }
       
}