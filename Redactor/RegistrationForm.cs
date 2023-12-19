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
            string userLogin = UserNameTB.Text;

            string userName = firstNameTB.Text;

            string userSurname = secondNameTB.Text;

            string userMail = emailTB.Text;

            string userPass = userPassTB.Text;

            DateTime birthday = birthDateDTP.Value;

            Role role = isReader.Checked == true ? Role.Reader : Role.Author;

            User newUser = new User(userLogin, userName, userSurname, userMail, userPass, birthday, role);

            UserRegistration.RegisterUser(newUser);

            Form1 autentificateForm = new Form1();
            autentificateForm.Show();
            Close();

            //string userName = UserNameTB.Text;

            //string userPass = userPassTB.Text;

            //User newUser = new User(userName);

            //newUser.Password = userPass;

            //UserRegistration.RegisterUser(newUser);

            //Form1 autentificationForm = new Form1();
            //autentificationForm.Show();
            //Close();
        }

        private void RegistrateBTN_Click(object sender, EventArgs e)
        {
            RegistrateNewUser();
        }

        private void isAuthor_CheckedChanged(object sender, EventArgs e)
        {
            isReader.Checked = false;
        }

        private void isReader_CheckedChanged(object sender, EventArgs e)
        {
            isAuthor.Checked = false;
        }
    }
}
