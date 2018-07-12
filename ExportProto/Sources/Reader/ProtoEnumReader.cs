using ETModel;
using LitJson;
using System;
using ETModel;
using LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class ProtoEnumReader
{
    public DoubleMap<string, ProtoEnumData> enums = new DoubleMap<string, ProtoEnumData>();

    public void Reads()
    {
        string root = Setting.Options.protoPath;
        string[] folders = Setting.Options.protoFolder.Split(',');

        for (int i = 0; i < folders.Length; i++)
        {
            string path = root + "/" + folders[i].Trim() + "/enum.json";
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
            ProtoEnumData oob = new ProtoEnumData();
            oob.name = key;
            this.enums.Add(oob.name, oob);


            JsonData jStruct = jsonData[key];
            foreach (var mKey in jStruct.Keys)
            {
                string fieldName = mKey.ToString();
                oob.Add(fieldName, jStruct[fieldName].ToString());

            }
        }



    }
}