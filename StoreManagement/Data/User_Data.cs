using StoreManagement.Entities;
using System.Collections.Generic;

namespace StoreManagement.Data
{
    public class User_Data
    {
        public static User[] ReadListUser()
        {
            User[] listUsers;
            string[] lines;
            string[] user;
            int userNumber = 0;

            const string path = "\\Files\\User.txt";
            string? dir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filepath = dir + path;
            StreamReader file = new StreamReader(filepath);
            lines = file.ReadToEnd().Split(new char[] { '\n' });
            file.Close();

            for (int i = 0; i < lines.Length; i++)
            {
                user = lines[i].Split(",");
                if (!string.IsNullOrEmpty(user[0]))
                {
                    userNumber++;
                }
            }

            listUsers = new User[userNumber];

            for (int i = 0; i < userNumber; i++)
            {
                user = lines[i].Split(",");
                if (!string.IsNullOrEmpty(user[0]))
                {
                    listUsers[i].UserName= user[0].Trim();
                    listUsers[i].Password = user[1].Trim();
                };
            }

            return listUsers;
        }
        public static void SaveUsers(string path, User[] listUsers)
        {
            string? dir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filepath = dir + path;
            StreamWriter file = new StreamWriter(filepath);
            string userName;
            string password;
            string line;
            for (int i = 0; i < listUsers.Length; i++)
            {
                userName = listUsers[i].UserName;
                password = listUsers[i].Password;
                line = userName + "," + password;
                file.WriteLine(line);
            }
            file.Close();
        }
    }
}
