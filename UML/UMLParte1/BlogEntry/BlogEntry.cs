using System;

namespace ejemplosClase;

public class BlogEntry : IEquatable<BlogEntry>
{
    private static long _numberOfPosts;
    private long _postId;

    public BlogEntry()
    {
        Post = "a";
        _postId = _numberOfPosts++;
    }

    // notar esta notación - es una Auto-Property
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
        return _postId == other._postId;
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
        return _postId.GetHashCode();
    }
    
}