namespace ImportarSinOCPPaso2;

public class FileImporter
{
    public void Import(string fileType, string fileName)
    {
        ImportTxt itxt = new ImportTxt(fileName);
        ImportCsv icsv = new ImportCsv(fileName);
        
        if (fileType.Equals("txt"))
            itxt.ImportTxtFile();
        else if (fileType.Equals("csv"))
            icsv.ImportCsvFile();
        else
            throw new NotImplementedException();
    }
}