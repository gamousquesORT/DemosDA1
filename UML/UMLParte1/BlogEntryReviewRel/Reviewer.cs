namespace BlogEntryReviewRel;

public class Reviewer
{
    private readonly List<BlogEntry> blogEntries = new();

    // la multiplicidad 0 .. *

    public Reviewer(string reviwerName)
    {
        this.ReviewerName = reviwerName;
    }

    public string ReviewerName { get; set; }

    public void AddBlogEntry(BlogEntry blogEntry)
    {
        blogEntries.Add(blogEntry);
    }

    public List<BlogEntry> BlogsToReview()
    {
        return blogEntries;
    }
}