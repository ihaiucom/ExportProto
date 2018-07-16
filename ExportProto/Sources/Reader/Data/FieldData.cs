
public class FieldData
{
    public string fieldName;
    public string fieldType;

    public string cnname = string.Empty;

    public string tsType
    {
        get
        {
            switch (fieldType)
            {
                case "bool":
                    return "boolean";
                case "int":
                case "float":
                case "double":
                    return "number";

                case "array<bool>":
                    return "boolean[]";

                case "array<string>":
                    return "string[]";

                case "array<int>":
                case "array<float>":
                case "array<double>":
                    return "number[]";
            }

            if (fieldType.StartsWith("array"))
            {
                return fieldType.Substring(fieldType.IndexOf("<") + 1, fieldType.LastIndexOf(">") - fieldType.IndexOf("<") - 1) + "[]";
            }

            return fieldType;
        }
    }
}