using System;
using System.Collections.Generic;
using System.Text;

public class TsPathTemplate
{

    public static string ApiHandler
    {
        get
        {
            return Setting.Options.templateDir + "/TS/ApiHandler.txt";
        }
    }

    public static string ApiHandler_Action
    {
        get
        {
            return Setting.Options.templateDir + "/TS/ApiHandler_Action.txt";
        }
    }

    public static string ApiSender
    {
        get
        {
            return Setting.Options.templateDir + "/TS/ApiSender.txt";
        }
    }

    public static string ApiSender_Action
    {
        get
        {
            return Setting.Options.templateDir + "/TS/ApiSender_Action.txt";
        }
    }

    public static string OobHandler
    {
        get
        {
            return Setting.Options.templateDir + "/TS/OobHandler.txt";
        }
    }

    public static string ProtoHandlerList
    {
        get
        {
            return Setting.Options.templateDir + "/TS/ProtoHandlerList.txt";
        }
    }

    public static string ProtoSenderList
    {
        get
        {
            return Setting.Options.templateDir + "/TS/ProtoSenderList.txt";
        }
    }

    public static string ProtoOobHandler
    {
        get
        {
            return Setting.Options.templateDir + "/TS/ProtoOobHandler.txt";
        }
    }

    public static string ProtoInclude
    {
        get
        {
            return Setting.Options.templateDir + "/TS/ProtoInclude.txt";
        }
    }

    public static string ProtoModuleNames
    {
        get
        {
            return Setting.Options.templateDir + "/TS/ProtoModuleNames.txt";
        }
    }

    public static string ProtoEventKey
    {
        get
        {
            return Setting.Options.templateDir + "/TS/ProtoEventKey.txt";
        }
    }
}