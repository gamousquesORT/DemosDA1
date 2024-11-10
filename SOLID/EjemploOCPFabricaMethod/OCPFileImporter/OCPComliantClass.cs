namespace OCPFileImporter;

public class OCPComliantClass
{
    private OcpCompilantClass? _importer=null;
    
    public OCPComliantClass()
    {

    }
    public OCPComliantClass(OcpCompilantClass? importer)
    {
        this.Importer = importer;
    }
    
    public OcpCompilantClass? Importer
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