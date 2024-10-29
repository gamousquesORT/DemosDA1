namespace ImportarSinOCP;

public class ClassThatNeedToIimportData
{
    private string _fileName;
    
    public void ImportTxt()
    {
        Console.WriteLine("Importando TXT "  + _fileName);
    }
    public void ImportCsv()
    {
        Console.WriteLine("Importando CSV " + _fileName);
    }

    public void Import(string fileType, string fileName)
    {
        _fileName = fileName;
        if (fileType.Equals("txt"))
            this.ImportTxt();
        else if (fileType.Equals("csv"))
            this.ImportCsv();
        else
            throw new NotImplementedException();
    }
}