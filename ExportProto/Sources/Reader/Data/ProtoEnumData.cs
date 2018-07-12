using System;
using System.Collections.Generic;
using System.Text;


public class ProtoEnumData: ProtoMsgActionData
{
    public string name;

    public string fullClassName
    {
        get
        {
            return Setting.Options.namespaceEnum + "." + name;
        }
    }

}