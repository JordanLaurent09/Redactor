using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace Redactor
{
    static class UserRegistration
    {
        private static List<User> _users;

        public static void RegisterUser(User newUser)
        {
            string _userDataPath = Directory.GetCurrentDirectory() + "\\users.json";

            string users = File.ReadAllText(_userDataPath);

            if(users == string.Empty)
            {
                _users = new List<User>();
            }
            else
            {
                _users = JsonConvert.DeserializeObject<List<User>>(users);
            }

            foreach(var user in _users)
            {
                if (user.Username.Equals(newUser.Username))
                {
                    MessageBox.Show("Пользователь с таким именем уже сушествует");
                    return;
                }
                else if (user.Email.Equals(newUser.Email))
                {
                    MessageBox.Show("Пользователь с таким адресом уже зарегистрирован");
                    return;
                }
            }

            newUser.Id = _users.Count + 1;
            newUser.RegistrationDate = DateTime.Now;
            _users.Add(newUser);


            SerializeUsersToJson(_users, _userDataPath);
        }

        public static void SerializeUsersToJson(List<User> users, string fileName)
        {
            JsonSerializer serializer = new JsonSerializer();

            using(StreamWriter sw = new StreamWriter(fileName))
                using(JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, users);
            }
        }
        //private static List<string> _users;


        //public static void RegisterUser(User newUser)
        //{
        //    string usersDataPath = Directory.GetCurrentDirectory() + "\\users.txt";

        //    string users = File.ReadAllText(usersDataPath);

        //    if(users == string.Empty)
        //    {
        //        _users = new List<string>();
        //    }
        //    else
        //    {
        //        string[] names = users.Split(' ');
        //        _users = new List<string>();

        //        for(int i = 0; i < names.Length; i++)
        //        {
        //            _users.Add(names[i]);
        //        }
        //    }

        //    foreach(string item in _users)
        //    {
        //        if (item.Equals(newUser.Username))
        //        {
        //            System.Windows.Forms.MessageBox.Show("Пользователь уже есть");
        //            return;
        //        }
        //    }

        //    _users.Add(newUser.Username);


        //    SendUsersToFile(_users, usersDataPath);

        //    Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}\\Articles\\{newUser.Username}");
        //}

        //public static void SendUsersToFile(List<string> users, string fileName)
        //{
        //    string text = string.Empty;
        //    foreach(string item in users)
        //    {
        //        text += item + " ";
        //    }
        //    StreamWriter writer = new StreamWriter(fileName);

        //    writer.WriteLine(text);
        //    writer.Close();
        //}
    }
}
