namespace OCPFileImporter;

public class OCPComliantClass
{
    private FileImporter? _importer=null;
    
    public OCPComliantClass()
    {

    }
    public OCPComliantClass(FileImporter? importer)
    {
        this.Importer = importer;
    }
    
    public FileImporter? Importer
    {
        set
        {
            if (value != null) _importer = value;
        }
    }
    
    public string ImportFile(string filename)
    {
        // este método puede hacer una cantidad importante de procesamiento antes y después de importar
        
        return _importer.ImportFile(filename);
    }
}