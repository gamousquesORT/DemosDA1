namespace ImportarSinOCPPaso2;

public class Program
{
    public static void Main(string[] args)
    {
        FileImporter importer = new FileImporter();
        importer.Import("txt", "archivoTXT");
        importer.Import("csv", "archivoCSV");
    }
}