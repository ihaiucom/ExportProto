
public class FieldData
{
    public string fieldName;
    public string fieldType;

    public string cnname = string.Empty;

    public string tsType
    {
        get
        {
            return fieldType;
        }
    }
}