using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redactor
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrateNewUser()
        {
            string userName = UserNameTB.Text;

            string userPass = userPassTB.Text;

            User newUser = new User(userName);

            newUser.Password = userPass;

            UserRegistration.RegisterUser(newUser);

            Form1 autentificationForm = new Form1();
            autentificationForm.Show();
            Close();
        }

        private void RegistrateBTN_Click(object sender, EventArgs e)
        {
            RegistrateNewUser();
        }
    }
}
