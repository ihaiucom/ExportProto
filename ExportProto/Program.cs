using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        //注册EncodeProvider
        //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        


        Setting.Init(args);

        ProtoManager pm = new ProtoManager();
        pm.ReadProto();
        pm.ReadProtoNote();
        pm.ExportCode();
        pm.ExportGMJson();


        Console.WriteLine("完成!");

        if (!Setting.Options.autoEnd)
            Console.Read();
    }
}