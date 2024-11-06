namespace OCPFileImporter;

public class FileImporter
{
    public static FileImporter Create(string type)
    {
        if (type.Equals("txt"))
            return new TxTFileImporter();
        else if (type.Equals("csv"))
            return new CsvFileImporter();
        else
        {
            throw new ArgumentException("ese tipo de archivo no se puede importar");
        }
    }
    
    public virtual string ImportFile(string filename)
    {
            throw new NotImplementedException("no se puede importar el tipo de arhivo");
    }
}

public class CsvFileImporter : FileImporter
{
    public override string ImportFile(string filename)
    {
            return "resultado de importar un CSV";
    }
}

public class TxTFileImporter : FileImporter
{
    public override string ImportFile(string filename)
    {
        return "resultado de importar un TxT";
    }
}