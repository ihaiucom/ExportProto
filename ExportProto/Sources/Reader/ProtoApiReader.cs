using ETModel;
using LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

public class ProtoApiReader
{
    public DoubleMap<string, ProtoModuleData> modules = new DoubleMap<string, ProtoModuleData>();

    public void Reads()
    {
        string root = Setting.Options.protoPath;
        string[] folders = Setting.Options.protoFolder.Split(',');

        for(int i = 0; i < folders.Length; i ++)
        {
            string path = root + "/" + folders[i].Trim() + "/api.json";
            if(File.Exists(path))
            {
                Read(path);
            }
        }
    }

    private void Read(string path)
    {
        Console.WriteLine(path);
        string jsonTxt = File.ReadAllText(path);
        JsonData jsonData = JsonMapper.ToObject(jsonTxt);

        foreach (var key in jsonData.Keys)
        {
            ProtoModuleData module = new ProtoModuleData();
            module.name = key;
            this.modules.Add(module.name, module);


            JsonData jModule = jsonData[key];

            foreach(var mKey in jModule.Keys)
            {
                ProtoMessageData msg = new ProtoMessageData();
                msg.name = mKey;
                module.AddMsg(msg);
                JsonData jMsg = jModule[mKey];
                JsonData jReq = jMsg["<req>"];
                JsonData jRes = jMsg["<res>"];

                foreach (var fieldKey in jReq.Keys)
                {
                    string fieldName = fieldKey.ToString();
                    msg.req.Add(fieldName, jReq[fieldName].ToString());

                }

                foreach (var fieldKey in jRes.Keys)
                {
                    string fieldName = fieldKey.ToString();
                    msg.res.Add(fieldName, jRes[fieldName].ToString());
                }
            }
        }


        ReadNote(jsonTxt);

    }

    private void ReadNote(string jsonTxt)
    {
        string pattern;
        Regex regex;
        MatchCollection mc;
        Match m;
        List<ProtoModuleData> moduleValues = modules.Values;
        foreach(ProtoModuleData module in moduleValues)
        {


            string modulename = $"\"{module.name}\"";
            pattern = $@"{modulename}\s*:\s*{{\s*//(.*)\n";
            regex = new Regex(pattern);

            mc = regex.Matches(jsonTxt);
            if(mc != null && mc.Count > 0)
            {
                m = mc[0];
                module.cnname = m.Groups[1].ToString();
                //Console.WriteLine(module.cnname);
            }


            List<ProtoMessageData>  msgValues = module.msgs.Values;
            foreach(ProtoMessageData msg in msgValues)
            {
                //Console.WriteLine();
                //Console.WriteLine("-----------");

                string msgname = $"\"{msg.name}\"";

                pattern = $@"{msgname}\s*:\s*{{\s*//(.*)\n";
                regex = new Regex(pattern);

                mc = regex.Matches(jsonTxt);
                if (mc != null && mc.Count > 0)
                {
                    m = mc[0];
                    msg.cnname = m.Groups[1].ToString().Replace("\n", "").Replace("\r", "");
                    //Console.WriteLine(msg.cnname);
                }


                //Console.WriteLine("~~~~~~~~~~~~~~~" + modulename + " " + msgname);
                int maxLine = msg.req.fields.Count + msg.res.fields.Count + 5;
                foreach (var kvp in msg.req.fields)
                {
                    string fieldname = $"\"{kvp.Value.fieldName}\"";
                    string res = "\"<req>\"";
                    //Console.WriteLine("fieldname: " + fieldname);

                    pattern = $@"{msgname}\s*:\s*{{[\s\S]*?{res}\s*:\s*{{[\s\S]*?{fieldname}\s*:.*//(.*)\n";
                    regex = new Regex(pattern);
                    //Console.WriteLine(pattern);

                    mc = regex.Matches(jsonTxt);
                    if (mc != null && mc.Count > 0)
                    {
                        m = mc[0];
                        if(m.ToString().Split('\n').Length <= maxLine)
                            kvp.Value.cnname = m.Groups[1].ToString();

                        //Console.WriteLine(kvp.Value.cnname);
                        //Console.WriteLine(m.ToString().Split('\n').Length);
                        //Console.WriteLine(m.ToString());
                    }
                }

                foreach (var kvp in msg.res.fields)
                {
                    string fieldname = $"\"{kvp.Value.fieldName}\"";
                    string res = "\"<res>\"";
                    pattern = $@"{msgname}\s*:\s*{{[\s\S]*?{res}\s*:\s*{{[\s\S]*?{fieldname}\s*:.*//(.*)\n";
                    regex = new Regex(pattern);
                    //Console.WriteLine(pattern);

                    mc = regex.Matches(jsonTxt);
                    if (mc != null && mc.Count > 0)
                    {
                        m = mc[0];
                        if (m.ToString().Split('\n').Length <= maxLine)
                            kvp.Value.cnname = m.Groups[1].ToString();

                        //Console.WriteLine(kvp.Value.cnname);
                        //Console.WriteLine(m.ToString().Split('\n').Length);
                        //Console.WriteLine(m.ToString());
                    }

                }

            }
        }
    }
}