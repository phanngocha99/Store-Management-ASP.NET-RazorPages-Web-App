using StoreManagement.Data;
using StoreManagement.Entities;
using System.Text.RegularExpressions;

namespace StoreManagement.Logic
{
    public class User_Logic
    {
        public static bool IsNotValidString(string S)
        {
            if (string.IsNullOrEmpty(S))
            {
                return true;
            }
            return false;
        }

        public static bool IsNotValidUserNameLength(string userName)
        {
            if (userName.Length < 3)
            {
                return true;
            }
            return false;
        }

        public static bool IsNotValidPasswordLength(string password)
        {
            if (password.Length < 5)
            {
                return true;
            }
            return false;
        }

        public static bool IsNotValidContainLetterPassword(string password)
        {
            int numberLetter;
            numberLetter = Regex.Matches(password, @"[a-zA-Z]").Count;
            if (numberLetter > 0)
            {
                return false;
            }
            return true;
        }

        public static bool IsNotValidContainLetterUserName(string UserName)
        {
            int numberLetter;
            numberLetter = Regex.Matches(UserName, @"[a-zA-Z]").Count;
            if (numberLetter > 0)
            {
                return false;
            }
            return true;
        }

        public static bool IsNotValidContainNumberPassword(string password)
        {
            int numberDigit;
            numberDigit = Regex.Matches(password, @"[0-9]").Count;
            if (numberDigit > 0)
            {
                return false;
            }
            return true;
        }

        public static bool IsNotValidContainSpecialLetterPassword(string password)
        {
            int Count;
            Count = Regex.Matches(password, @"[^a-zA-Z0-9]").Count;
            if (Count > 0)
            {
                return false;
            }
            return true;
        }

        public static bool IsNotUniqueUserName(string userName)
        {
            User[] listUsers = User_Data.ReadListUser();

            for (int i = 0; i < listUsers.Length; i++)
            {
                if (userName == listUsers[i].UserName)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsNotContainBlankSpaceUserName(string userName)
        {
            return userName.Contains(" ");
        }

        public static bool IsNotContainBlankSpacePassword(string password)
        {
            return password.Contains(" ");
        }

        public static bool AddUser(User newUser)
        {
            User[] listUsers = User_Data.ReadListUser();
            User[] newListUsers = new User[listUsers.Length + 1];

            for (int i = 0; i < listUsers.Length; i++)
            {
                newListUsers[i] = listUsers[i];
            }
            newListUsers[listUsers.Length] = newUser;

            const string path = "\\Files\\User.txt";
            User_Data.SaveUsers(path, newListUsers);

            return true;
        }

        public static bool FindUser(User newUser)
        {
            User[] listUsers = User_Data.ReadListUser();

            for (int i = 0; i < listUsers.Length; i++)
            {
                if (listUsers[i].UserName.Equals(newUser.UserName) && listUsers[i].Password.Equals(newUser.Password))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool FindUserByUserName(string userName)
        {
            User[] listUsers = User_Data.ReadListUser();

            for (int i = 0; i < listUsers.Length; i++)
            {
                if (userName == listUsers[i].UserName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
