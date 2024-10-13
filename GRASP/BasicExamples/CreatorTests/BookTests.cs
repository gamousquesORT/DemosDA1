using Creator;

namespace BookTests;


[TestClass]
public class BookTests
{
    [TestMethod]
    public void GivenATitle_ReturnsABookWithTheTitle()
    {
        Book book = new Book("Meditations");
        string expected = "Meditations";
        Assert.AreEqual(expected, book.Title);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GivenAnEmptyTitle_ReturnsArgumentException()
    {
        Book book = new Book("");
    }
}