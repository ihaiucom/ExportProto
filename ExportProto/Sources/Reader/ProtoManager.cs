using System;
using System.Collections.Generic;
using System.Text;


public class ProtoManager
{
    public ProtoApiReader apiReader = new ProtoApiReader();
    public ProtoStructReader structReader = new ProtoStructReader();
    public ProtoEnumReader enumReader = new ProtoEnumReader();
    

    public void ReadProto()
    {
        apiReader.Reads();
        structReader.Reads();
        enumReader.Reads();
    }

    public void ReadProtoNote()
    {

    }

    public void ExportCode()
    {
        TSExportProtoEventKey.Export(this);
        TSExportProtoHandlerList.Export(this);
        TSExportProtoSenderList.Export(this);
        TSExportProtoOobHandler.Export(this);
        TSExportProtoModuleNames.Export(this);
        TSExportProtoInclude.Export(this);
        TSExportOobHandler.Export(this);
        TSExportApiHandler.Export(this);
        TSExportApiSender.Export(this);

        JsonExportGM.Export(this);
    }

    public void ExportGMJson()
    {

    }
}