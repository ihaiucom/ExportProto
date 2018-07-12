using System;
using System.Collections.Generic;
using System.Text;


public class ProtoStructData: ProtoMsgActionData
{
    public string name;

    public string funName
    {
        get
        {
            return name + "Handler";
        }
    }


    public string fullClassName
    {
        get
        {
            return Setting.Options.namespaceStruct + "." + name;
        }
    }
}