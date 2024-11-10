using OCPFileImporter;

namespace OCPFileImporterTests;

[TestClass]
public class OCPCompilantClassTests
{
    [TestMethod]
    public void GivenTheFileNameForCsvFile_ShouldImportTheFileContent()
    {
        string expected = "resultado de importar un CSV";
        OcpCompilantClass ocpClass = new CsvOcpCompilantClass();
        Assert.AreEqual(expected, ocpClass.ImportFile("Archivoprueba"));
    }

    [TestMethod]
    public void GivenTheFileNameForTxtFile_ShouldImportTheFileContent()
    {
        OcpCompilantClass? ocpClass = OcpCompilantClass.Create("txt");
        string expected = "resultado de importar un TxT";
        Assert.AreEqual(expected, ocpClass.ImportFile("Archivoprueba"));
    }
    
    [TestMethod]
    public void GivenACSVType_ShouldCreateACsvImporter()
    {
        OcpCompilantClass? ocpClass = OcpCompilantClass.Create("csv");
        Type expectedType = typeof(CsvOcpCompilantClass);
   
        Assert.IsInstanceOfType(ocpClass, expectedType);
    }
    
    [TestMethod]
    public void GivenATxtType_ShouldCreateATxTImporter()
    {
        OcpCompilantClass? ocpClass = OcpCompilantClass.Create("csv");
        Type expectedType = typeof(CsvOcpCompilantClass);
   
        Assert.IsInstanceOfType(ocpClass, expectedType);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GivenAnInvalidFileType_ShouldThrowAArguementException()
    {
        OcpCompilantClass? ocpClass = OcpCompilantClass.Create("sml");
    }



}