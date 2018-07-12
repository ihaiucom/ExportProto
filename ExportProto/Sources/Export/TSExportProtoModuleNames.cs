using BeardedManStudios.Templating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


public class TSExportProtoModuleNames
{
    public static void Export(ProtoManager pm)
    {

        List<object[]> apilist = new List<object[]>();

        List<ProtoModuleData> apiValues =  pm.apiReader.modules.Values;
        foreach(var module in apiValues)
        {
            apilist.Add(new object[] { module.name, module.name });
        }


        TemplateSystem template = new TemplateSystem(File.ReadAllText(TsPathTemplate.ProtoModuleNames));
        template.AddVariable("apilist", apilist.ToArray());
        string content = template.Parse();
        string path = string.Format(TsPathOut.ProtoModuleNames);

        PathHelper.CheckPath(path);
        File.WriteAllText(path, content);
    }
}