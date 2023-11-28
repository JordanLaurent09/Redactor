using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Redactor
{
    static class UserRegistration
    {
        private static List<string> _users;


        public static void RegisterUser(User newUser)
        {
            string usersDataPath = Directory.GetCurrentDirectory() + "\\users.txt";

            string users = File.ReadAllText(usersDataPath);

            if(users == string.Empty)
            {
                _users = new List<string>();
            }
            else
            {
                string[] names = users.Split(' ');
                _users = new List<string>();

                for(int i = 0; i < names.Length; i++)
                {
                    _users.Add(names[i]);
                }
            }

            foreach(string item in _users)
            {
                if (item.Equals(newUser.Username))
                {
                    System.Windows.Forms.MessageBox.Show("Пользователь уже есть");
                    return;
                }
            }

            _users.Add(newUser.Username);


            SendUsersToFile(_users, usersDataPath);

            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\" + newUser.Username);
        }

        public static void SendUsersToFile(List<string> users, string fileName)
        {
            string text = string.Empty;
            foreach(string item in users)
            {
                text += item + " ";
            }
            StreamWriter writer = new StreamWriter(fileName);

            writer.WriteLine(text);
            writer.Close();
        }
    }
}
