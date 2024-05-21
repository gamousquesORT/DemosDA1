// See https://aka.ms/new-console-template for more information

using System.Net;
namespace LibraryMngmt;
public class Program
{
    public static void Main()
    {
        Library library = new Library();
        
        while (true)
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. List Books");
            Console.WriteLine("3. Add Author");
            Console.WriteLine("4. List Authors");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter book title: ");
                string title = Console.ReadLine();
                Console.Write("Enter book author: ");
                string name = Console.ReadLine();
                Author author = new Author(name);
                Book book = new Book(title, author);
                library.AddAuthor(author);
                book.Author = author;
                library.AddBook(book);
            }
            else if (choice == "2")
            {
                library.ListBooks();
            }
            else if (choice == "3")
            {
                Console.Write("Enter book author: ");
                string name = Console.ReadLine();
                
                Author author = new Author(name);
                library.AddAuthor(author);
            }
            else if (choice == "4")
            {
                library.ListAuthors();
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }
}

