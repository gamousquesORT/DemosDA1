namespace OCPFileImporter;

public class ImporterFactory
{

    public IFileImporter Create(string type)
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
}