namespace ImportarSinOCPPaso1;

public class FileImporter
{
    private string _fileName;
    
    public void ImportTxtFile()
    {
        Console.WriteLine("Importando TXT "  + _fileName);
    }
    public void ImportCsvFile()
    {
        Console.WriteLine("Importando CSV " + _fileName);
    }

    public void Import(string fileType, string fileName)
    {
        _fileName = fileName;
        if (fileType.Equals("txt"))
            this.ImportTxtFile();
        else if (fileType.Equals("csv"))
            this.ImportCsvFile();
        else
            throw new NotImplementedException();
    }
}