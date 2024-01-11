using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            articlesLB.Items.Clear();
            string articlesPath = $"{_path}\\{authorsLB.Text}";

            DirectoryInfo dirInfo = new DirectoryInfo(articlesPath);

            FileInfo[] files = dirInfo.GetFiles();

            foreach(var item in files)
            {
                _titles.Add(item.Name);
                articlesLB.Items.Add(item.Name.Substring(0, item.Name.Length - 5));
            }
        }


        // Вывод статьи в текстбоксы 
        private void articlesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string articleName = $"{articlesLB.SelectedItem.ToString()}.json";

            string fullPathToFile = $"{_path}\\{authorsLB.Text}\\{articleName}";

            string article = File.ReadAllText(fullPathToFile);

            List<string> text = Cypher.EncryptArticles(JsonConvert.DeserializeObject<List<string>>(article));

            List<string> temp = new List<string>();

            headerTB.Text = text[1];
            underHeaderTB.Text = text[2];

            for(int i = 3; i < text.Count; i++)
            {
                temp.Add(text[i]);
            }

            articleTB.Lines = temp.ToArray();
        }

        // Завершение работы с программой при закрытии формы 
        private void ReaderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
