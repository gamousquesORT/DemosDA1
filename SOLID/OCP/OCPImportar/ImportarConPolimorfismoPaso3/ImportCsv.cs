namespace ImportarConPolimorfismoPaso3;

public class ImportCsv : Importer
{

    public override void ImportFile(string fileName)
    {
        Console.WriteLine("Importando TXT "  + fileName);
    }
}
