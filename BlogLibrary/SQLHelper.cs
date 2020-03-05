using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;

namespace BlogAndDatabase
{
    public class SQLHelper
    {
        private const string DB_NAME = "Blog_DB_Access";
        private const string DB_ERROR = "ERROR: An error occured when connecting to the database.\n\n" +
                                        "Have you installed the Access Database Engine (32-bit)?";

        //function that uses Dapper to fetch data from the database
        private static List<T> Fetch<T>(string query)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                IDbConnection connection = new System.Data.OleDb.OleDbConnection(ConfigurationManager.ConnectionStrings[DB_NAME].ConnectionString);
                List<T> results = new List<T>();

                using (connection)
                {
                    results = connection.Query<T>(query).ToList();
                }

                return results;
            }
            catch
            {
                MessageBox.Show(DB_ERROR);
                Environment.Exit(1);
            }

            Cursor.Current = Cursors.Default;

            return null;
        }

        //function that uses Dapper to send data to the database
        private static void Send(string query)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                IDbConnection connection = new System.Data.OleDb.OleDbConnection(ConfigurationManager.ConnectionStrings[DB_NAME].ConnectionString);

                using (connection)
                {
                    connection.Execute(query);
                }
            }
            catch
            {
                MessageBox.Show(DB_ERROR);
                Environment.Exit(1);
            }

            Cursor.Current = Cursors.Default;
        }

        public static bool ValidateUserExists(User user)
        {
            List<User> users = Fetch<User>($"SELECT * FROM Users WHERE Username = '{user.Username}' AND Password = '{user.Password}'");

            //check for case sensitivity
            return users.Count.Equals(1) && user.Username.Equals(users[0].Username) && user.Password.Equals(users[0].Password);
        }

        public static bool ValidateUniqueUsername(string username)
        {
            List<User> users = Fetch<User>($"SELECT * FROM Users WHERE Username = '{username}'");

            return users.Count.Equals(0);
        }

        public static void AddNewUser(User user)
        {
            Send($"INSERT INTO Users ([Username], [Password]) VALUES ('{user.Username}', '{user.Password}')");
        }

        public static List<Post> GetTop100Posts()
        {
            List<Post> posts = Fetch<Post>("SELECT TOP 100 * FROM Posts ORDER BY PostDate ASC");

            return posts;
        }

        public static string GetUsernameById(int id)
        {
            string username = Fetch<User>($"SELECT * FROM Users WHERE Id = " + id)[0].Username;

            return username;
        }

        public static int GetIdByUsername(string username)
        {
            int id = Fetch<User>($"SELECT * FROM Users WHERE Username = '{username}'")[0].Id;

            return id;
        }

        public static void AddNewPost(Post post)
        {
            Send($"INSERT INTO Posts(PostUserId, PostDate, PostContent) VALUES ('{post.PostUserId}', '{post.PostDate}', '{post.PostContent}')");
        }
    }
}
