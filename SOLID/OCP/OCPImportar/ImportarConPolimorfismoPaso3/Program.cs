namespace ImportarConPolimorfismoPaso3;

public class Program
{
    public static void Main(string[] args)
    {
        FileImporter importer = new FileImporter();
        
        Importer imp;
        imp = new ImportTxt();
        importer.Import(imp, "archivo");
        
        imp = new ImportCsv();
        importer.Import(imp, "archivo");
        
        imp = new ImportXml();
        importer.Import(imp, "archivo");
    }
}