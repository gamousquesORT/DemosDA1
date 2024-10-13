namespace Creator;

public class Library
{
    private Dictionary<int, LibraryMember> _members = new Dictionary<int, LibraryMember>();
    private Dictionary<string, Book> _books = new Dictionary<string, Book>();
    private List<Loan> _loans = new List<Loan>();
    private IDateTime _dateTime;

    public Library(IDateTime date)
    {
        _dateTime = date;
    }
    public void AddMember(int id, string name)
    {
        _members.Add(id, new LibraryMember(id, name));
    }

    public void BuyBook(string name)
    {
        _books.Add(name, new Book(name));
    }

    public void LoanBookToMember(string bookTitle, int memberId)
    {
        try
        {
            LibraryMember member = _members[memberId];
            Book book = _books[bookTitle];
            _loans.Add(new Loan(member, book, _dateTime));

        }
        catch (KeyNotFoundException e)
        {
            Console.WriteLine(e);
            throw new ArgumentException("Invalid Member or book");
        }

    }

    public bool MemberHasLoans(int memberId)
    {
        try
        {
            LibraryMember member = _members[memberId];
            return _loans.Any(loan => loan.BelongsToMember(member));

        }
        catch (KeyNotFoundException e)
        {
            Console.WriteLine(e);
            throw new ArgumentException("Invalid Member or book");
        }

    }
}