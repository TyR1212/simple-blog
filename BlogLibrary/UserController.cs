using System.Linq;

namespace BlogAndDatabase
{
    public class UserController
    {
        public bool AttemptLogin(User loginUser)
        {
            bool userExists = SQLHelper.ValidateUserExists(loginUser);

            return userExists;
        }

        public bool AttemptSignUp(User signUpUser)
        {
            bool isUsernameUnique = SQLHelper.ValidateUniqueUsername(signUpUser.Username);

            if (isUsernameUnique)
            {
                SQLHelper.AddNewUser(signUpUser);
                return true;
            }
            else
                return false;
        }

        public bool ValidateCredentials(User signUpUser)
        {
            if (ValidateUsername(signUpUser.Username) && ValidatePassword(signUpUser.Password))
                return true;
            else
                return false;
        }

        private bool ValidateUsername(string username)
        {
            if (ContainsUnicode(username) || username.Contains(' '))
                return false;

            if (username.Length >= 4 && GetNumOfLetters(username) >= 1)
                return true;
            else
                return false;
        }

        private bool ValidatePassword(string password)
        {
            if (ContainsUnicode(password) || password.Contains(' '))
                return false;

            if (password.Length >= 8 && GetNumOfLetters(password) >= 4 && GetNumOfDigits(password) >= 1)
                return true;
            else
                return false;
        }

        private bool ContainsUnicode(string str)
        {
            foreach (char ch in str)
                if (ch > 127)
                    return true;

            return false;
        }

        private int GetNumOfLetters(string str)
        {
            int numLetters = 0;

            foreach (char ch in str)
                if (char.IsLetter(ch))
                    numLetters++;

            return numLetters;
        }

        private int GetNumOfDigits(string str)
        {
            int numDigits = 0;

            foreach (char ch in str)
                if (char.IsDigit(ch))
                    numDigits++;

            return numDigits;
        }
    }
}
