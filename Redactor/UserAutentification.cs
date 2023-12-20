﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Redactor.RoleOfUsers;
using System.IO;

namespace Redactor
{
    class UserAutentification
    {
        public void Autentificate(string userLogin)
        {
            StreamReader reader = new StreamReader("users.txt");
            string usersData = reader.ReadToEnd();

            string[] names = usersData.Split(' ');

            reader.Close();

            User currentUser = null;

            foreach(string item in names)
            {
                if(item == userLogin)
                {
                    currentUser = new User(item);
                }
            }

            if(currentUser == null)
            {
                System.Windows.Forms.MessageBox.Show("Пользователь не найден");
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
