using System;

namespace BlogAndDatabase
{
    public class Post
    {
        public int PostId { get; set; }
        public int PostUserId { get; set; }
        public DateTime PostDate { get; set; }
        public string PostContent { get; set; }
    }
}
