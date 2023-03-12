namespace BlogEntryReviewRel;

public class Reviewer
{
    private List<BlogEntry> blogEntries = new List<BlogEntry>();  
    // la multiplicidad 0 .. *
    private String reviwerName;

    public Reviewer(string reviwerName)
    {
        this.reviwerName = reviwerName;
    }
    public string ReviewerName
    {
        get => reviwerName;
        set => reviwerName = value;
    }
    
    public void AddBlogEntry(BlogEntry blogEntry)
    {
        this.blogEntries.Add(blogEntry);
    }

    public List<BlogEntry> BlogsToReview()
    {
        return blogEntries;
    }
}