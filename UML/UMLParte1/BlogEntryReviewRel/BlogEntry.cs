namespace BlogEntryReviewRel;

public class BlogEntry
{
    private String _post = "a";
    private long _postID;
    private static long _numberOfPosts = 0;

    public BlogEntry()
    {
        _post = "a";
        _postID = _numberOfPosts++;
    }
    
    public string Post
    {
        get => _post;
        set => _post = value;
    }
    

    public override string ToString() 
    {
        return this.Post;
    }

    public bool Equals(BlogEntry? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _postID == other._postID;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((BlogEntry) obj);
    }

    public override int GetHashCode()
    {
        return _postID.GetHashCode();
    }

    public static bool operator ==(BlogEntry? left, BlogEntry? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(BlogEntry? left, BlogEntry? right)
    {
        return !Equals(left, right);
    }
}

