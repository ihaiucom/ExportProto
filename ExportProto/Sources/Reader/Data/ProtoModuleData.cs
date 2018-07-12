using ETModel;
using System;
using System.Collections.Generic;
using System.Text;


public class ProtoModuleData
{
    public string name;
    public string cnname = string.Empty;

    public DoubleMap<string, ProtoMessageData> msgs = new DoubleMap<string, ProtoMessageData>();

    public void AddMsg(ProtoMessageData msg)
    {
        msg.module = this;
        msgs.Add(msg.name, msg);
    }

    public string moduleHandlerClassName
    {
        get
        {
            return name + "Handler";
        }
    }

    public string moduleSenderClassName
    {
        get
        {
            return name + "Sender";
        }
    }
}