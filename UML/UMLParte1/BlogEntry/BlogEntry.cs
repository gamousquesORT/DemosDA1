using System;

namespace ejemplosClase
{
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
    
        public void PostInfo(String entry)
        {
            _post = entry;
        }

        public String PostInfoAsText()
        {
            return _post;
        }

        public static long GetNumberOfPosts()
        {
            return _numberOfPosts;
        }

        public override string ToString() 
        {
            return this.PostInfoAsText();
        }


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((BlogEntry)obj);
        }

        public override int GetHashCode() => (_post != null ? _post.GetHashCode() : 0);

    }
}
