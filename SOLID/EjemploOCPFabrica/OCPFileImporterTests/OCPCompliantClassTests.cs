using OCPFileImporter;

namespace OCPFileImporterTests;

[TestClass]
public class OCPCompliantClassTests
{
    [TestMethod]
    public void GivenTheFileNameForCsvFile_ShouldImportTheFileContent()
    {
        string expected = "resultado de importar un CSV";
        ImporterFactory importerFactory = new ImporterFactory();
        OCPComliantClass ocpClass = new OCPComliantClass(importerFactory);
        Assert.AreEqual(expected, ocpClass.ImportFile("Archivoprueba", "csv"));
    }

    [TestMethod]
    public void GivenTheFileNameForTxtFile_ShouldImportTheFileContent()
    {
        string expected = "resultado de importar un TxT";
        ImporterFactory importerFactory = new ImporterFactory();
        OCPComliantClass ocpClass = new OCPComliantClass(importerFactory);
        Assert.AreEqual(expected, ocpClass.ImportFile("Archivoprueba", "txt"));
    }
    

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GivenAnInvalidFileType_ShouldThrowAArguementException()
    {
        string expected = "resultado de importar un xml";
        ImporterFactory importerFactory = new ImporterFactory();
        OCPComliantClass ocpClass = new OCPComliantClass(importerFactory);
        Assert.AreEqual(expected, ocpClass.ImportFile("Archivoprueba", "xml"));
    }
}