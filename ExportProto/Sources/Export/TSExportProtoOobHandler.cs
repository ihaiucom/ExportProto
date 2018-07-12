using BeardedManStudios.Templating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


public class TSExportProtoOobHandler
{
    public static void Export(ProtoManager pm)
    {

        List<object[]> ooblist = new List<object[]>();

        List<ProtoStructData> oobValues = pm.structReader.structs.Values;

        foreach (var oob in oobValues)
        {
            ooblist.Add(new object[] { oob.funName });
        }


        TemplateSystem template = new TemplateSystem(File.ReadAllText(TsPathTemplate.ProtoOobHandler));
        template.AddVariable("ooblist", ooblist.ToArray());
        string content = template.Parse();
        string path = string.Format(TsPathOut.ProtoOobHandler);

        PathHelper.CheckPath(path);
        File.WriteAllText(path, content);
    }
}