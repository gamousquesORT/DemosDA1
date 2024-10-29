namespace ImportarConPolimorfismoPaso3;

public class FileImporter
{
    public void Import(Importer importer, string fileName) // se injecta el importador
    {
        importer.ImportFile(fileName);
    }
}