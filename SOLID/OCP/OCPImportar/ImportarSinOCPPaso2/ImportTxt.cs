namespace ImportarSinOCPPaso2;

public class ImportTxt
{
    private string _fileName;
    
    public ImportTxt(string fileName)
    {
        _fileName = fileName;
    }

    public void ImportTxtFile()
    {
        Console.WriteLine("Importando TXT "  + _fileName);
    }
}
