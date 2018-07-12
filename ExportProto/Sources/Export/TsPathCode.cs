using System;
using System.Collections.Generic;
using System.Text;


public static class TsPathCode
{
    public static string ApiHandler
    {
        get
        {
            return Setting.Options.codePath + "/controller/{1}Handler.ts";
        }
    }

    public static string ApiSender
    {
        get
        {
            return Setting.Options.codePath + "/controller/{1}Sender.ts";
        }
    }

    public static string OobHandler
    {
        get
        {
            return Setting.Options.codePath + "/oobhandler/{1}Handler.ts";
        }
    }


}