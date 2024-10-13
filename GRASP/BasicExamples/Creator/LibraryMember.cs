namespace Creator;

public class LibraryMember
{
    public string Name { get; set; }
    public int Id { set; get; }
    private List<Loan> _loans = new List<Loan>();

    public LibraryMember(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public bool LoanBook(string member, string title)
    {
        return true;
    }

    protected bool Equals(LibraryMember other)
    {
        return Id == other.Id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((LibraryMember)obj);
    }

    public override int GetHashCode()
    {
        return Id;
    }
}