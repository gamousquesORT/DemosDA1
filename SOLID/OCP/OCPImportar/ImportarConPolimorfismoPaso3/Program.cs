namespace ImportarConPolimorfismoPaso3;

public class Program
{
    public static void Main(string[] args)
    {
        FileImporter importer = new FileImporter();
        
        Importer imp;
        imp = new ImportTxt();
        importer.Import(imp, "archivoTXT");
        
        imp = new ImportCsv();
        importer.Import(imp, "archivoCSV");
        
        imp = new ImportXml();
        importer.Import(imp, "archivoXML");
    }
}