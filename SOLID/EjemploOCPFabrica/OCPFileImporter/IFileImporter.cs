namespace OCPFileImporter;

public interface IFileImporter
{
    public string ImportFile(string filename);
}

public class CsvFileImporter : IFileImporter
{
    public  string ImportFile(string filename)
    {
            return "resultado de importar un CSV";
    }
}

public class TxTFileImporter : IFileImporter
{
    public  string ImportFile(string filename)
    {
        return "resultado de importar un TxT";
    }
}