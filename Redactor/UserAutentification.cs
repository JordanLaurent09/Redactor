using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Redactor.RoleOfUsers;
using System.IO;

namespace Redactor
{
    class UserAutentification
    {
        public void Autentificate(string userLogin, string userPassword)
        {
            StreamReader reader = new StreamReader("users.txt");
            string usersData = reader.ReadToEnd();
            User[] users = JsonConvert.DeserializeObject<User[]>(usersData) ?? throw new Exception("Нет данных");
            //string[] names = usersData.Split(' ');

            reader.Close();

            User currentUser = null;

            foreach(User user in users)
            {
                if(user.Username == userLogin && user.Password == userPassword)
                {
                    currentUser = user;
                }
            }

            //foreach(string item in names)
            //{
            //    if(item == userLogin)
            //    {
            //        currentUser = new User(item);
            //    }
            //}

            if(currentUser == null)
            {
                System.Windows.Forms.MessageBox.Show("Пользователь не найден или пароль неверен");
                return;
            }

            IsUserAutenticate(currentUser);

        }

        private void IsUserAutenticate(User currentUser)
        {
            switch (currentUser.Role)
            {
                case Role.Admin:
                    AdminPanel adminPanel = new AdminPanel(currentUser);
                    adminPanel.Show();
                    break;
                case Role.Reader:
                    ReaderForm readerForm = new ReaderForm(currentUser);
                    readerForm.Show();
                    break;
                case Role.Author:
                    AuthorForm authorForm = new AuthorForm(currentUser);
                    authorForm.Show();
                    break;
            }
            //if (currentUser.Username == "admin")
            //{
            //    RoleOfUsers.AdminPanel admin = new RoleOfUsers.AdminPanel(currentUser);
            //    admin.Show();
            //}
            //else if(currentUser.Username == "reader")
            //{
            //    RoleOfUsers.ReaderForm reader = new RoleOfUsers.ReaderForm(currentUser);
            //    reader.Show();
            //}
            //else
            //{
            //    RoleOfUsers.AuthorForm author = new RoleOfUsers.AuthorForm(currentUser);
            //    author.Show();
            //}
        }
    }
}
