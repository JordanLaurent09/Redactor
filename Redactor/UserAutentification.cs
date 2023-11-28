using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            RoleOfUsers.AuthorForm author = new RoleOfUsers.AuthorForm(currentUser);
            author.Show();
        }
    }
}
