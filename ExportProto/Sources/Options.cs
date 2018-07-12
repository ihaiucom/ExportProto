using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CommandLine;

public class Options
{
    // 运行完，是否自动关闭cmd
    [Option("autoEnd", Required = false, Default = true)]
    public bool autoEnd { get; set; }

    // 启动参数设置 配置路径
    [Option("optionSetting", Required = false, Default = "./ExportProtoSetting.json")]
    public string optionSetting { get; set; }

    // 协议路径
    [Option("protoPath", Required = false, Default = "E:/zengfeng/GamePF/gamepf_doc/Tool-Proto")]
    public string protoPath { get; set; }

    // 协议路径文件夹
    [Option("protoFolder", Required = false, Default = "client_only,common")]
    public string protoFolder { get; set; }

    // 模板目录
    [Option("templateDir", Required = false, Default = "../ExportProto/Template")]
    public string templateDir { get; set; }

    // 代码--代码路径
    [Option("codePath", Required = false, Default = "E:/zengfeng/GamePF/Gidea-PF-Client/GamePF/src/proto")]
    public string codePath { get; set; }

    // 代码--代码保存路径
    [Option("codeOutPath", Required = false, Default = "./out")]
    public string codeOutPath { get; set; }


    // 命名空间--枚举
    [Option("namespaceEnum", Required = false, Default = "Proto.SE")]
    public string namespaceEnum { get; set; }

    // 命名空间--Struct
    [Option("namespaceStruct", Required = false, Default = "Proto.SS")]
    public string namespaceStruct { get; set; }

    // 命名空间--Api
    [Option("namespaceApi", Required = false, Default = "Proto.API")]
    public string namespaceApi { get; set; }

    // GM配置--服务器
    [Option("jsonServerGM", Required = false, Default = "//172.16.50.177/GamePF/ServerGM.json")]
    public string jsonServerGM { get; set; }

    // GM配置--客户端
    [Option("jsonClientGM", Required = false, Default = "./out/ClientGM.json")]
    public string jsonClientGM { get; set; }




    public void Save(string path = null)
    {
        if (string.IsNullOrEmpty(path))
            path = "./ExportProtoSetting.json";

        string json = JsonHelper.ToJsonType(this);
        File.WriteAllText(path, json);
    }

    public static Options Load(string path = null)
    {
        if (string.IsNullOrEmpty(path))
            path = "./ExportProtoSetting.json";

        string json = File.ReadAllText(path);
        Options options = JsonHelper.FromJson<Options>(json);
        return options;
    }
}