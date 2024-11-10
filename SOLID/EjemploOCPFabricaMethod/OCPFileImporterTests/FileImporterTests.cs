using OCPFileImporter;

namespace OCPFileImporterTests;

[TestClass]
public class FileImporterTests
{
    [TestMethod]
    public void GivenTheFileNameForCsvFile_ShouldImportTheFileContent()
    {
        string expected = "resultado de importar un CSV";
        FileImporter importer = new CsvFileImporter();
        Assert.AreEqual(expected, importer.ImportFile("Archivoprueba"));
    }

    [TestMethod]
    public void GivenTheFileNameForTxtFile_ShouldImportTheFileContent()
    {
        FileImporter? importer = FileImporter.Create("txt");
        string expected = "resultado de importar un TxT";
        Assert.AreEqual(expected, importer.ImportFile("Archivoprueba"));
    }
    
    [TestMethod]
    public void GivenACSVType_ShouldCreateACsvImporter()
    {
        FileImporter? importer = FileImporter.Create("csv");
        Type expectedType = typeof(CsvFileImporter);
   
        Assert.IsInstanceOfType(importer, expectedType);
    }
    
    [TestMethod]
    public void GivenATxtType_ShouldCreateATxTImporter()
    {
        FileImporter? importer = FileImporter.Create("csv");
        Type expectedType = typeof(CsvFileImporter);
   
        Assert.IsInstanceOfType(importer, expectedType);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GivenAnInvalidFileType_ShouldThrowAArguementException()
    {
        FileImporter? importer = FileImporter.Create("sml");
        Type expectedType = typeof(TxTFileImporter);
    }
    


}