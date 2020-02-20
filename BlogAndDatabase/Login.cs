using System;
using System.Windows.Forms;

namespace BlogAndDatabase
{
    public partial class Login : Form
    {
        private string currentUsername = "";
        private UserController userCont = new UserController();

        public Login()
        {
            InitializeComponent();
            //MessageBox.Show(System.Environment.CurrentDirectory);
            usernameTextBox.Focus();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool loginSuccessful = userCont.AttemptLogin(new User { Username = usernameTextBox.Text, Password = passwordTextBox.Text});

            if (loginSuccessful)
            {
                currentUsername = usernameTextBox.Text;

                Dashboard dashboardWindow = new Dashboard(currentUsername);
                dashboardWindow.Show();
                Hide();
            }
            else
            {
                ShowInvalidLoginError();
                passwordTextBox.Text = "";
                passwordTextBox.Focus();
            }
        }

        private void ShowInvalidLoginError()
        {
            MessageBox.Show("Username or password is incorrect.");
        }

        private void usernameAndPasswordTextBoxes_TextChanged(object sender, EventArgs e)
        {
            if (!usernameTextBox.Text.Equals("") && !passwordTextBox.Text.Equals(""))
                loginButton.Enabled = true;
            else
                loginButton.Enabled = false;
        }

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpWindow = new SignUp();
            signUpWindow.Show();
            Hide();
        }

        private void showCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showCheckBox.Checked)
                passwordTextBox.UseSystemPasswordChar = false;
            else
                passwordTextBox.UseSystemPasswordChar = true;
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) && loginButton.Enabled)
            {
                loginButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
