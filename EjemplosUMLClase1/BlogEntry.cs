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
    }
}
