// See https://aka.ms/new-console-template for more information

namespace BlogEntryReviewRel;

public class Program
{
    public static void Main(string[] args)
    {
        var reviewer = new Reviewer("Gastón");

        var blogEntry = new BlogEntry();
        blogEntry.Post = "mi primer post";
        reviewer.AddBlogEntry(blogEntry);

        blogEntry = new BlogEntry();
        blogEntry.Post = "mi segundo post";
        reviewer.AddBlogEntry(blogEntry);

        foreach (var p in reviewer.BlogsToReview()) Console.WriteLine("El post dice: " + p + "\n");
    }
}