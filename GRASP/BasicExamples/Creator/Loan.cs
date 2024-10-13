namespace Creator;

public class Loan
{
    private Book _book;
    private IDateTime _loanDate;
    private LibraryMember _member;
    public Loan(LibraryMember memberId, Book book, IDateTime date)
    {
        _member = memberId;
        _book = book;
        _loanDate = date;
    }

    public bool BelongsToMember(LibraryMember member)
    {
        return _member.Equals(member);
    }
    public DateTime LoanDate
    {
        get { return _loanDate.Date;}
    }

    public string BookTitle()
    {
        return _book.Title;
    }
    

}
