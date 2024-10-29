namespace ImportarConPolimorfismoPaso3;

public class ImportTxt : Importer
{
    public override void ImportFile(string fileName)
    {
        Console.WriteLine("Importando TXT "  + fileName);
    }
}
