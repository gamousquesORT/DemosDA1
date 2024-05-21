namespace LibraryMngmt;

using System;
using System.Collections.Generic;

public class Author
{

    private string _name =null;
    public Author(string name)
    {
        Name = name;
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}
public class Book
{
    public string Title { get; set; }
    public Author Author { get; set; }

    public Book(string title, Author author)
    {
        Title = title;
        Author = author;
    }
}
public class Library
{
    public List<Book> Books { get; private set; } = new List<Book>();
    public List<Author> Authors { get; private set; } = new List<Author>();
    public void AddBook(Book book)
    {
        Books.Add(book);
    }
    public void AddAuthor(Author author)
    {
        Authors.Add(author);
    }
    public void ListBooks()
    {
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
        }
    }
    public void ListAuthors()
    {
        foreach (var author in Authors)
        {
            Console.WriteLine($"Title: {author.Name}");
        }
    }
}