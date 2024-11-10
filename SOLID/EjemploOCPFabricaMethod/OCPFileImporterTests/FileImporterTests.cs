using OCPFileImporter;

namespace OCPFileImporterTests;

[TestClass]
public class FileImporterTests
{
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
    }
        
}