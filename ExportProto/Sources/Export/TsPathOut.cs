using System;
using System.Collections.Generic;
using System.Text;


public static class TsPathOut
{
    public static string ApiHandler
    {
        get
        {
            return Setting.Options.codeOutPath + "/controller/{0}Handler.ts";
        }
    }

    public static string ApiSender
    {
        get
        {
            return Setting.Options.codeOutPath + "/controller/{0}Sender.ts";
        }
    }

    public static string OobHandler
    {
        get
        {
            return Setting.Options.codeOutPath + "/oobhandler/{0}.ts";
        }
    }



    public static string ProtoHandlerList
    {
        get
        {
            return Setting.Options.codeOutPath + "/ProtoHandlerList.ts";
        }
    }



    public static string ProtoSenderList
    {
        get
        {
            return Setting.Options.codeOutPath + "/ProtoSenderList.ts";
        }
    }



    public static string ProtoOobHandler
    {
        get
        {
            return Setting.Options.codeOutPath + "/ProtoOobHandler.ts";
        }
    }


    public static string ProtoInclude
    {
        get
        {
            return Setting.Options.codeOutPath + "/ProtoInclude.ts";
        }
    }


    public static string ProtoModuleNames
    {
        get
        {
            return Setting.Options.codeOutPath + "/ProtoModuleNames.ts";
        }
    }


    public static string ProtoEventKey
    {
        get
        {
            return Setting.Options.codeOutPath + "/ProtoEventKey.ts";
        }
    }


}