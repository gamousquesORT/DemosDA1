using System;

namespace ejemplosClase
{
    public class BlogEntry
    {
        private String post = "";
        private long postID;
        static private long numberOfPosts = 0;

        public BlogEntry()
        {
            postID = numberOfPosts++;
        }

        public void PostInfo(String entry)
        {
            post = entry;
        }

        public String postInfoAsText()
        {
            return post;
        }

        public static long getNumberOfPosts()
        {
            return numberOfPosts;
        }

        public override string ToString() 
        {
            return this.postInfoAsText();
        }


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((BlogEntry)obj);
        }

        public override int GetHashCode() => (post != null ? post.GetHashCode() : 0);

    }
}
