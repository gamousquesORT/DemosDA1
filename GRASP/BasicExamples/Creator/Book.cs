namespace Creator;

public class Book
{
    public string Title { get; set; }

    public Book(string title)
    {
        if (title.Length == 0)
            throw new ArgumentException("Empty book title");
        Title = title;
    }
}