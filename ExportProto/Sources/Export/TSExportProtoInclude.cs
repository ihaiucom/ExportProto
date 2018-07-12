using BeardedManStudios.Templating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


public class TSExportProtoInclude
{
    public static void Export(ProtoManager pm)
    {

        List<object[]> enumlist = new List<object[]>();

        List<ProtoEnumData> enumValues = pm.enumReader.enums.Values;

        foreach (var item in enumValues)
        {
            enumlist.Add(new object[] { item.name, item.fullClassName });
        }


        TemplateSystem template = new TemplateSystem(File.ReadAllText(TsPathTemplate.ProtoInclude));
        template.AddVariable("enumlist", enumlist.ToArray());
        string content = template.Parse();
        string path = string.Format(TsPathOut.ProtoInclude);

        PathHelper.CheckPath(path);
        File.WriteAllText(path, content);
    }
}