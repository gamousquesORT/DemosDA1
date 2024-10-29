namespace ImportarSinOCPPaso2;

public class ImportCsv
{
    private string _fileName;
    
    public ImportCsv(string fileName)
    {
        _fileName = fileName;
    }

    public void ImportCsvFile()
    {
        Console.WriteLine("Importando TXT "  + _fileName);
    }
}
