using Creator;

namespace BookTests;

[TestClass]
public class LibraryTests
{
    private IDateTime _dateDouble;
    private Library _library;
    
    [TestInitialize]
    public void Setup()
    {
        _dateDouble = new MyDateTimeStub();
        _library = new Library(_dateDouble);
        _library.AddMember(1, "Juan");
        _library.AddMember(2, "María");
        _library.BuyBook("Meditaciones");
        _library.BuyBook("Cartas a Lucilio");
        _library.BuyBook("Enquiridion");
    }

    [TestMethod]
    public void GivenAValidMemberAndALoanedBook_ReturnsTrue()
    {
        _library.LoanBookToMember("Meditaciones", 1);

        Assert.IsTrue(_library.MemberHasLoans(1));
    }
    
    [TestMethod]
    public void GivenAValidMemberWithnoLaons_ReturnsFalse()
    {

        Assert.IsFalse(_library.MemberHasLoans(1));
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GivenAValidMemberAndAnInvalidBook_ThrowsArgumentException()
    {
        _library.LoanBookToMember("Principito", 1);
    }

}