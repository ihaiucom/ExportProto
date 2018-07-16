using ETModel;
using LitJson;
using System;
using ETModel;
using LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

public class ProtoStructReader
{
    public DoubleMap<string, ProtoStructData> structs = new DoubleMap<string, ProtoStructData>();

    public void Reads()
    {
        string root = Setting.Options.protoPath;
        string[] folders = Setting.Options.protoFolder.Split(',');

        for (int i = 0; i < folders.Length; i++)
        {
            string path = root + "/" + folders[i].Trim() + "/struct.json";
            if (File.Exists(path))
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
            ProtoStructData oob = new ProtoStructData();
            oob.name = key;
            this.structs.Add(oob.name, oob);


            JsonData jStruct = jsonData[key];
            foreach (var mKey in jStruct.Keys)
            {
                string fieldName = mKey.ToString();
                oob.Add(fieldName, jStruct[fieldName].ToString());

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
        List<ProtoStructData> structList = structs.Values;
        foreach (ProtoStructData structData in structList)
        {


            string structName = $"\"{structData.name}\"";
            pattern = $@"{structName}\s*:\s*{{\s*//(.*)\n";
            regex = new Regex(pattern);

            mc = regex.Matches(jsonTxt);
            if (mc != null && mc.Count > 0)
            {
                m = mc[0];
                structData.cnname = m.Groups[1].ToString();
                //Console.WriteLine(structData.cnname);
            }

            int maxLine = structData.fields.Count + 3;
            foreach (var kvp in structData.fields)
            {
                string fieldname = $"\"{kvp.Value.fieldName}\"";
                //Console.WriteLine("fieldname: " + fieldname);

                pattern = $@"{structName}\s*:\s*{{[\s\S]*?{fieldname}\s*:.*//(.*)\n";
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