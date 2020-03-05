using System.Collections.Generic;
using System.Text;

namespace BlogAndDatabase
{
    public class PostController
    {
        public string GetPostsToString()
        {
            StringBuilder postsString = new StringBuilder();
            string postUsername = "";
            List<Post> posts = SQLHelper.GetTop100Posts();

            foreach (Post post in posts)
            {
                postUsername = SQLHelper.GetUsernameById(post.PostUserId);
                postsString.Append($"{ post.PostContent }\r\n{ postUsername }\r\n{ post.PostDate.ToString("M/d/yyyy h:mm tt") }\r\n\r\n");
            }

            return postsString.ToString();
        }

        public void PostMessage(Post post)
        {
            post.PostContent = post.PostContent.TrimEnd();

            //sanitize single quotes
            if (post.PostContent.Contains("'"))
                for (int i = 0; i < post.PostContent.Length; i++)
                    if (post.PostContent[i] == '\'')
                    {
                        post.PostContent = post.PostContent.Insert(i, "'");
                        i++;
                    }

            SQLHelper.AddNewPost(post);
        }
    }
}
