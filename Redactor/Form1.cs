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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Аутентификация пользователя
        private void logBTN_Click(object sender, EventArgs e)
        {
            UserAutentification userAutentification = new UserAutentification();
            userAutentification.Autentificate(userLoginTB.Text, userPasswordTB.Text);
            if (userAutentification.isAutentificate == true)
            {
                Hide();
            }
        }

        // Регистрация пользователя
        private void regBTN_Click(object sender, EventArgs e)
        {
            Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        // Закрытие потока программы после ее закрытия
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
