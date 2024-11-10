namespace OCPFileImporter;

public abstract class FileImporter
{
    public static FileImporter? Create(string? type)
    {
        if (type != null && type.Equals("txt"))
            return new TxTFileImporter();
        else if (type != null && type.Equals("csv"))
            return new CsvFileImporter();
        else
        {
            throw new ArgumentException("ese tipo de archivo no se puede importar");
        }
    }

    public abstract string ImportFile(string filename);
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