using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlogAndDatabase
{
    public partial class Dashboard : Form
    {
        private string currentUsername = "";
        private PostController postCont = new PostController();

        public Dashboard(string username)
        {
            InitializeComponent();

            currentUsername = username;
            usernameLabel.Text = currentUsername;
            postFeedTextBox.BackColor = Color.White;

            RefreshPostFeed();
        }

        private void RefreshPostFeed()
        {
            postFeedTextBox.Text = postCont.GetPostsToString();
            ScrollToBottom(postFeedTextBox);

            postTextBox.Focus();
        }

        private void RefreshCharCounter()
        {
            charCountLabel.Text = postTextBox.Text.Length.ToString() + "/170";
        }

        private void ScrollToBottom(TextBox textBox)
        {
            textBox.SelectionStart = textBox.Text.Length;
            textBox.ScrollToCaret();
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            int userId = SQLHelper.GetIdByUsername(currentUsername);

            postCont.PostMessage(new Post
            {
                PostUserId = userId,
                PostDate = DateTime.Now,
                PostContent = postTextBox.Text
            });

            postTextBox.Text = "";
            RefreshPostFeed();
            RefreshCharCounter();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshPostFeed();
        }

        private void postTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!postTextBox.Text.Equals(""))
                postButton.Enabled = true;
            else
                postButton.Enabled = false;

            if (postTextBox.Text.Length >= 171)
            {
                postTextBox.Text = postTextBox.Text.Remove(170);
                ScrollToBottom(postTextBox);
            }

            RefreshCharCounter();
        }

        private void postTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                postButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void postFeedTextBox_Enter(object sender, EventArgs e)
        {
            postTextBox.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
            Hide();
        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            RefreshPostFeed();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
