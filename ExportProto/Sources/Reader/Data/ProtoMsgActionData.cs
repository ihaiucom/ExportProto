using System;
using System.Collections.Generic;
using System.Text;

public class ProtoMsgActionData
{
    public Dictionary<string, FieldData> fields = new Dictionary<string, FieldData>();
    public void Add(string fieldName, string fieldType)
    {
        FieldData field = new FieldData();
        field.fieldName = fieldName;
        field.fieldType = fieldType;
        fields.Add(fieldName, field);
    }

    public string code;
}