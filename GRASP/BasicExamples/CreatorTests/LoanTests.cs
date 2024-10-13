using Creator;

namespace BookTests;


[TestClass]
public class LoanTest
{
    private Book _book;
    private IDateTime _dateDouble;
    private Loan _loan;
    private LibraryMember _member = new LibraryMember(1, "María");
    
    [TestInitialize]
    public void Setup()
    {
        _book = new Book("Meditations");
        _dateDouble = new MyDateTimeStub();
        _loan = new Loan(_member, _book, _dateDouble);
    }

    [TestMethod]
    public void GivenABookWithATitle_ReturnsTheTitleAsString()
    {
        string expected = "Meditations";
        Assert.AreEqual(expected, _loan.BookTitle());
    }
    
    [TestMethod]
    public void GivenABookWithATitle_ReturnsTheLoadDate()
    {
        _dateDouble = new MyDateTimeStub("2024-10-12");
        
        _loan = new Loan(_member, _book, _dateDouble);
        IDateTime expected = new MyDateTimeStub("2024-10-12") ;
        Assert.AreEqual(expected.Date, _loan.LoanDate);
    }

    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GivenAnEmptyTitle_ReturnsArgumentException()
    {
        Book book = new Book("");
        Loan loan = new Loan(_member,book, _dateDouble);
    }
}
