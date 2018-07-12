using BeardedManStudios.Templating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

public class TSExportApiHandler
{
    public static void Export(ProtoManager pm)
    {
        List<ProtoModuleData> apiValues =  pm.apiReader.modules.Values;
        foreach(var module in apiValues)
        {
            ExportModule(module);
        }

    }


    private static string _tplContent;
    private static string tplContent
    {
        get
        {
            if (_tplContent == null)
            {
                _tplContent = File.ReadAllText(TsPathTemplate.ApiHandler);
            }
            return _tplContent;
        }
    }


    private static string _tplAction;
    private static string tplAction
    {
        get
        {
            if (_tplAction == null)
            {
                _tplAction = File.ReadAllText(TsPathTemplate.ApiHandler_Action);
            }
            return _tplAction;
        }
    }


    private static void ExportModule(ProtoModuleData data)
    {
        List<object[]> funCodeList = new List<object[]>();

        List<ProtoMessageData> msgValues =  data.msgs.Values;
        foreach(var msgData in msgValues)
        {
            string code = GenerateFunCode(msgData);
            msgData.res.code = code;
            funCodeList.Add(new object[] { code });
        }

        string path = string.Format(TsPathOut.ApiHandler, data.name);
        string content = "";
        if (!File.Exists(path))
        {
            TemplateSystem template = new TemplateSystem(tplContent);
            template.AddVariable("classNote", data.cnname);
            template.AddVariable("className", data.moduleHandlerClassName);
            template.AddVariable("name", data.name);
            template.AddVariable("funCodeList", funCodeList.ToArray());
            content = template.Parse();
            PathHelper.CheckPath(path);
            File.WriteAllText(path, content);
        }
        else
        {

            List<string> addCodeList = new List<string>();
            string code = File.ReadAllText(path);

            foreach (var msgData in msgValues)
            {
                string pattern = $@"{msgData.name}\s*\(.*:\s*{msgData.resFullName.Replace(".", @"\.")}\)\s*{{";
                Regex regex = new Regex(pattern);
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine(pattern);
                //Console.WriteLine(regex.IsMatch(code));
                if (!regex.IsMatch(code))
                {
                    addCodeList.Add(msgData.res.code);
                }

                //int i = 0;
                //MatchCollection mc = regex.Matches(code);
                //foreach(var v in mc)
                //{
                //    Console.WriteLine(i + "  " + v.ToString());
                //    i++;
                //}
            }

            if(addCodeList.Count > 0)
            {
                string pattern = @"}\s*}";
                Regex regex = new Regex(pattern, RegexOptions.RightToLeft);
                code = regex.Replace(code, String.Join("", addCodeList) + "\n\t}\n}", 1);

                File.WriteAllText(path, code);
            }
        }



    }

    private static string GenerateFunCode(ProtoMessageData data)
    {

        TemplateSystem template = new TemplateSystem(tplAction);
        template.AddVariable("cnname", data.cnname);
        template.AddVariable("funName", data.name);
        template.AddVariable("msgType", data.resFullName);
        string content = template.Parse();
        return content;
    }

}