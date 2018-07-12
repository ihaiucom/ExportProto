using BeardedManStudios.Templating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


public class TSExportOobHandler
{
    public static void Export(ProtoManager pm)
    {
        List<ProtoStructData> oobValues = pm.structReader.structs.Values;

        foreach (var oob in oobValues)
        {
            ExportStruct(oob);
        }


    }

    private static string _tplContent;
    private static string tplContent
    {
        get
        {
            if(_tplContent == null)
            {
                _tplContent = File.ReadAllText(TsPathTemplate.OobHandler);
            }
            return _tplContent;
        }
    }

    private static void ExportStruct(ProtoStructData data)
    {
        string path = string.Format(TsPathOut.OobHandler, data.funName);
        if(File.Exists(path))
        {
            return;
        }


        TemplateSystem template = new TemplateSystem(tplContent);
        template.AddVariable("funName", data.funName);
        template.AddVariable("fullClassName", data.fullClassName);
        string content = template.Parse();

        PathHelper.CheckPath(path);
        File.WriteAllText(path, content);
    }
}