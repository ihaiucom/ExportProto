using System;
using System.Collections.Generic;
using System.Text;


public class ProtoMessageData
{
    public ProtoModuleData module;
    public string name;
    public string cnname = string.Empty;

    public ProtoMsgReqData req = new ProtoMsgReqData();
    public ProtoMsgResData res = new ProtoMsgResData();

    public string resFullName
    {
        get
        {
            return Setting.Options.namespaceApi + "." + module.name + "." + name + "Response";
        }
    }


    public string reqFullName
    {
        get
        {
            return Setting.Options.namespaceApi + "." + module.name + "." + name + "Request";
        }
    }

}