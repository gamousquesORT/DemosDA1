namespace OCPFileImporter;

public abstract class OcpCompilantClass
{
    public static OcpCompilantClass? Create(string? type)
    {
        if (type != null && type.Equals("txt"))
            return new TxTOcpCompilantClass();
        else if (type != null && type.Equals("csv"))
            return new CsvOcpCompilantClass();
        else
        {
            throw new ArgumentException("ese tipo de archivo no se puede importar");
        }
    }

    public abstract string ImportFile(string filename);
}

public class CsvOcpCompilantClass : OcpCompilantClass
{
    public override string ImportFile(string filename)
    {
            return "resultado de importar un CSV";
    }
}

public class TxTOcpCompilantClass : OcpCompilantClass
{
    public override string ImportFile(string filename)
    {
        return "resultado de importar un TxT";
    }
}