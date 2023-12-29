using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Newtonsoft.Json;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Redactor.RoleOfUsers
{
    public partial class AdminPanel : Form
    {
        private static List<User> _users = new List<User>();
        private static string _path = $"{Directory.GetCurrentDirectory()}\\users.json";
        public User AdminUser { get; set; }

        public AdminPanel(User user)
        {
            InitializeComponent();
            AdminUser = user;

            GetUsersList();
        }


        // Вывод списка пользователей в листбокс
        public void GetUsersList()
        {
            string usersInfo = File.ReadAllText(_path);

            _users = JsonConvert.DeserializeObject<List<User>>(usersInfo);
            
            for(int i = 0; i < _users.Count; i++)
            {
                usersLB.Items.Add(_users[i].Username);
            }
        }

        // Создание пользователя администратором
        private void createUserBTN_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }


        // Отображение информации о пользователе при выборе его логина
        private void usersLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            usersLB.Text = usersLB.SelectedItem.ToString();

            foreach(User user in _users)
            {
                if(usersLB.Text == user.Username)
                {
                    idTB.Text = user.Id.ToString();
                    firstNameTB.Text = user.FirstName;
                    secondNameTB.Text = user.SecondName;
                    emailTB.Text = user.Email;
                    birthDateTB.Text = user.BirthDate.ToString();
                    regDateTB.Text = user.RegistrationDate.ToString();
                    roleTB.Text = user.Role.ToString();
                    isBlockedTB.Text = user.IsBlocked.ToString();
                }
                
            }
        }

        // Блокировка пользователя
        private void blockUserBTN_Click(object sender, EventArgs e)
        {
            if(isBlockedTB.Text != string.Empty && isBlockedTB.Text != "True")
            {
                isBlockedTB.Text = "True";

                foreach(User user in _users)
                {
                    if(usersLB.Text == user.Username)
                    {
                        user.IsBlocked = true;
                        MessageBox.Show("Пользователь успешно заблокирован!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пользователь либо не выбран, либо уже заблокирован");
                return;
            }
        }


        // Разблокировка пользователя
        private void unblockUserBTN_Click(object sender, EventArgs e)
        {
            if (isBlockedTB.Text != string.Empty && isBlockedTB.Text != "False")
            {
                isBlockedTB.Text = "False";

                foreach (User user in _users)
                {
                    if (usersLB.Text == user.Username)
                    {
                        user.IsBlocked = false;
                        MessageBox.Show("Пользователь успешно разблокирован!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пользователь либо не выбран, либо уже разблокирован");
                return;
            }
        }



        // Запись обновленного списка пользователей в файл
    }
}
