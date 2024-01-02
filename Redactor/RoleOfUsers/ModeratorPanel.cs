using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace Redactor.RoleOfUsers
{
    public partial class ModeratorPanel : Form
    {
        private static List<User> _users = new List<User>();
        private static string _path = $"{Directory.GetCurrentDirectory()}\\users.json";

        public User CurrentUser { get; set; }
        public ModeratorPanel(User user)
        {
            InitializeComponent();
            CurrentUser = user;
            GetUsers();
        }


        // Получение списка пользователей и размещение их логинов в листбоксе
        public void GetUsers()
        {
            string info = File.ReadAllText(_path);
            _users = JsonConvert.DeserializeObject<List<User>>(info);

            foreach(User user in _users)
            {
                authorsLB.Items.Add(user.Username);
            }
        }
    }
}
