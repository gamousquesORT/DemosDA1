using OCPFileImporter;

namespace OCPFileImporterTests;

[TestClass]
public class OCPCompilantClassTests
{
    private OCPCompliantClass _ocpClass = new OCPCompliantClass();
    
    [TestMethod]
    public void GivenTheFileNameForCsvFile_ShouldImportTheFileContent()
    {
        string expected = "resultado de importar un CSV";
        _ocpClass.Importer = FileImporter.Create("csv");
        Assert.AreEqual(expected, _ocpClass.ImportFile("Archivoprueba"));
    }

    [TestMethod]
    public void GivenTheFileNameForTxtFile_ShouldImportTheFileContent()
    {
        string expected = "resultado de importar un TxT";
        _ocpClass.Importer = FileImporter.Create("txt");
        Assert.AreEqual(expected, _ocpClass.ImportFile("Archivoprueba"));
    }
    
}