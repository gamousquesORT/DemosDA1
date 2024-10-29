namespace ImportarSinOCPPaso2;

public class Program
{
    public static void Main(string[] args)
    {
        FileImporter importer = new FileImporter();
        importer.Import("txt", "archivo");
        importer.Import("csv", "archivo");
    }
}