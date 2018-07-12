using BeardedManStudios.Templating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


public class TSExportProtoEventKey
{
    public static void Export(ProtoManager pm)
    {

        List<object[]> apilist = new List<object[]>();
        List<object[]> ooblist = new List<object[]>();

        List<ProtoModuleData> apiValues =  pm.apiReader.modules.Values;
        foreach(var module in apiValues)
        {
            List<ProtoMessageData> msgValues = module.msgs.Values;
            foreach (var msg in msgValues)
            {
                apilist.Add(new object[] { module.name, msg.name });
            }
        }


        List<ProtoStructData> oobValues = pm.structReader.structs.Values;

        foreach (var oob in oobValues)
        {
            ooblist.Add(new object[] { oob.name });
        }



        TemplateSystem template = new TemplateSystem(File.ReadAllText(TsPathTemplate.ProtoEventKey));
        template.AddVariable("apilist", apilist.ToArray());
        template.AddVariable("ooblist", ooblist.ToArray());
        string content = template.Parse();
        string path = string.Format(TsPathOut.ProtoEventKey);

        PathHelper.CheckPath(path);
        File.WriteAllText(path, content);
    }
}