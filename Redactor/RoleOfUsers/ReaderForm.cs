using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Redactor.RoleOfUsers
{
    public partial class ReaderForm : Form
    {
        private static List<string> _names = new List<string>(); // имена авторов
        private static List<string> _titles = new List<string>(); // названия статей
        private static string _path = $"{Directory.GetCurrentDirectory()}\\AuthorArticles";


        public User ReaderUser { get; set; }
        public ReaderForm(User reader)
        {
            InitializeComponent();
            ReaderUser = reader;
            CreateAuthorsList();
        }


        // Заполнение именами авторов списка
        public void CreateAuthorsList()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(_path);
       
            DirectoryInfo[] directories = dirInfo.GetDirectories();

            foreach(var item in directories)
            {
                authorsLB.Items.Add(item.Name);
            }
        }
        

        // Отображение статей при выборе автора
        private void authorsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string articlesPath = $"{_path}\\{authorsLB.Text}";

            DirectoryInfo dirInfo = new DirectoryInfo(articlesPath);

            FileInfo[] files = dirInfo.GetFiles();

            foreach(var item in files)
            {
                _titles.Add(item.Name);
                articlesLB.Items.Add(item.Name.Substring(0, item.Name.Length - 5));
            }
        }
    }
}
