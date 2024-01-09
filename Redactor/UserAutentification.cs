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
            StreamReader reader = new StreamReader("users.json");
            string usersData = reader.ReadToEnd();
            User[] users = JsonConvert.DeserializeObject<User[]>(usersData) ?? throw new Exception("Нет данных");
            

            reader.Close();

            User currentUser = null;

            List<User> listUsers = users.ToList();

            List<User> decryptUsers = Cypher.EncryptUsers(listUsers);

            foreach(User user in decryptUsers)
            {
                if(user.Username == userLogin && user.Password == userPassword && user.IsBlocked == false)
                {
                    currentUser = user;
                }
                else if(user.Username == userLogin && user.Password == userPassword && user.IsBlocked == true)
                {
                    System.Windows.Forms.MessageBox.Show("Вы заблокированы! Доступ запрещен. До свидания!");
                    return;
                }
            }

            

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
                    if (currentUser.IsRedactor == true)
                    {
                        ModeratorPanel modPanel = new ModeratorPanel(currentUser);
                        modPanel.Show();
                    }
                    else
                    {
                        ReaderForm readerForm = new ReaderForm(currentUser);
                        readerForm.Show();
                    }
                    break;
                case Role.Author:
                    AuthorForm authorForm = new AuthorForm(currentUser);
                    authorForm.Show();
                    break;
            }
            
        }
    }
}
