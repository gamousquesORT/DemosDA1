using OCPFileImporter;

namespace OCPFileImporterTests;

[TestClass]
public class FileImporterTests
{
    
    [TestMethod]
    public void GivenACSVType_ShouldCreateACsvImporter()
    {
        ImporterFactory importerFactory = new ImporterFactory();
        IFileImporter importer = importerFactory.Create("csv");
        Type expectedType = typeof(CsvFileImporter);
   
        Assert.IsInstanceOfType(importer, expectedType);
    }
    
    [TestMethod]
    public void GivenATxtType_ShouldCreateATxTImporter()
    {
        ImporterFactory importerFactory = new ImporterFactory();
        IFileImporter importer = importerFactory.Create("csv");
        Type expectedType = typeof(CsvFileImporter);
   
        Assert.IsInstanceOfType(importer, expectedType);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GivenAnInvalidFileType_ShouldThrowAArguementException()
    {
        ImporterFactory importerFactory = new ImporterFactory();
        IFileImporter importer = importerFactory.Create("sml");
    }

}