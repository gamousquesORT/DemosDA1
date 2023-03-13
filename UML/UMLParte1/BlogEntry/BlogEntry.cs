using System;

namespace ejemplosClase;

public class BlogEntry : IEquatable<BlogEntry>
{
    private static long _numberOfPosts;
    private long _postID;

    public BlogEntry()
    {
        Post = "a";
        _postID = _numberOfPosts++;
    }

    public string Post { get; set; } = "a";


    public static long GetNumberOfPosts()
    {
        return _numberOfPosts;
    }

    public override string ToString()
    {
        return Post;
    }

    public bool Equals(BlogEntry other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _postID == other._postID;
    }

    public override bool Equals(object obj)
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
    
}