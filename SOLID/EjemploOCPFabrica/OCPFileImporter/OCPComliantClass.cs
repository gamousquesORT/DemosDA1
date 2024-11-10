namespace OCPFileImporter;

public class OCPComliantClass
{
    private ImporterFactory _importerFactory;
    
    public OCPComliantClass()
    {

    }
    public OCPComliantClass(ImporterFactory importerFactory)
    {
        _importerFactory = importerFactory;
    }
    
    public string ImportFile(string filename, string fileType)
    {
        // este método puede hacer una cantidad importante de procesamiento antes y después de importar
        // se crea el importador de archivos según el tipo de archivo
        IFileImporter importer = _importerFactory.Create(fileType);
        return importer.ImportFile(filename);
    }
}