using System;
using System.Windows.Forms;

namespace BlogAndDatabase
{
    public partial class SignUp : Form
    {
        private string currentUsername = "";
        private UserController userCont = new UserController();

        public SignUp()
        {
            InitializeComponent();

            usernameTextBox.Focus();
        }

        private void usernameAndPasswordTextBoxes_TextChanged(object sender, EventArgs e)
        {
            if (!usernameTextBox.Text.Equals("") && !passwordTextBox.Text.Equals(""))
                signUpButton.Enabled = true;
            else
                signUpButton.Enabled = false;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            User signUpUser = new User { Username = usernameTextBox.Text, Password = passwordTextBox.Text };
            bool credentialsAreValid = userCont.ValidateCredentials(signUpUser);

            if (credentialsAreValid)
            {
                bool signUpSuccessful = userCont.AttemptSignUp(signUpUser);

                if (signUpSuccessful)
                {
                    currentUsername = signUpUser.Username;

                    Dashboard dashboardWindow = new Dashboard(currentUsername);
                    dashboardWindow.Show();
                    Hide();
                }
                else
                    ShowUsernameTakenError(signUpUser.Username);
            }
            else
                ShowCriteriaError();
        }

        private void ShowUsernameTakenError(string username)
        {
            MessageBox.Show($"Username \"{username}\" is already taken.");
        }

        private void ShowCriteriaError()
        {
            MessageBox.Show("Username must be at least 4 characters long and must contain at least 1 letter.\n" +
                    "Password must be at least 8 characters long and must conatin at least 4 letters and 1 number.\n" +
                    "Plain text only.\nSpaces not allowed.");
        }

        private void cancelLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
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
            if (e.KeyCode.Equals(Keys.Enter) && signUpButton.Enabled)
            {
                signUpButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
