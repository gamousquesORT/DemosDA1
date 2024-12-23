namespace OCPFileImporter;

public class OCPCompliantClass
{
    private FileImporter? _importer;

    public FileImporter Importer
    {
        get => _importer;
        set => _importer = value;
    }
    public string ImportFile(string fileName)
    {
        // este método puede ser mucho mas complejo. lo importante es notar que 
        // no tiene código de importación de archivos, eso se refactoreo a la clase FileImporter
        
        return _importer.ImportFile(fileName);
    }
}