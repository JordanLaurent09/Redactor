using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Redactor.RoleOfUsers
{
    public partial class AdminPanel : Form
    {
        private static List<string> _users = new List<string>();
        private static string _path = $"{Directory.GetCurrentDirectory()}\\users.txt";
        public User AdminUser { get; set; }

        public AdminPanel(User user)
        {
            InitializeComponent();
            AdminUser = user;

            GetUsersList();
        }


        public void GetUsersList()
        {
            StreamReader streamReader = new StreamReader(_path);

            string usersData = streamReader.ReadToEnd();

            string[] names = usersData.Split(' ');

            streamReader.Close();

            for(int i = 0; i < names.Length; i++)
            {
                usersLB.Items.Add(names[i]);
            }
        }

        private void createUserBTN_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
    }
}
