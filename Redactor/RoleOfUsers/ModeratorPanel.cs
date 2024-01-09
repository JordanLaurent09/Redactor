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
        private static List<User> _users = new List<User>(); // Список пользователей
        private static string _path = $"{Directory.GetCurrentDirectory()}\\users.json"; // Путь к файлу с пользователями
        private static string _articlesFolderPath = $"{Directory.GetCurrentDirectory()}\\AuthorArticles"; // Путь к папке со статьями пользователей 
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
            _users = Cypher.EncryptUsers(JsonConvert.DeserializeObject<List<User>>(info));

            foreach(User user in _users)
            {
                if (user.Role.ToString() == "Author")
                {
                    authorsLB.Items.Add(user.Username);
                }
            }
        }

        // Добавление статей конкретного автора в список статей
        private void authorsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddAuthorArticles();
        }

        private void AddAuthorArticles()
        {
            string author = authorsLB.SelectedItem.ToString();

            foreach (User user in _users)
            {
                if (author == user.Username)
                {
                    foreach (string articleName in user.ArticleList)
                    {
                        articlesLB.Items.Add(articleName);
                    }
                }
            }
        }


        // Просмотр содержимого текущей статьи
        private void articlesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowArticle();
        }

        private void ShowArticle()
        {
            List<string> temp = new List<string>();
            List<string> articleElements;

            string articlePath = $"{_articlesFolderPath}\\{authorsLB.Text}\\{articlesLB.Text}.json";

            string info = File.ReadAllText(articlePath);

            articleElements = Cypher.EncryptArticles(JsonConvert.DeserializeObject<List<string>>(info));

            HeadetTB.Text = articleElements[1];
            underHeaderTB.Text = articleElements[2];

            for (int i = 3; i < articleElements.Count; i++)
            {
                temp.Add(articleElements[i]);
            }

            articleTB.Lines = temp.ToArray();
        }


        // Загрузка в файл отредактированной статьи
        private void editArticleBTN_Click(object sender, EventArgs e)
        {
            SaveEditedArticle();
        }

        private void SaveEditedArticle()
        {
            string articlePath = $"{_articlesFolderPath}\\{authorsLB.Text}\\{articlesLB.Text}.json";
            List<string> editedArticle = new List<string>();

            editedArticle.Add(articlesLB.Text);
            editedArticle.Add(HeadetTB.Text);
            editedArticle.Add(underHeaderTB.Text);
            foreach (string line in articleTB.Lines)
            {
                editedArticle.Add(line);
            }

            List<string> encryptedArticle = Cypher.EncryptArticles(editedArticle);

            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter streamWriter = new StreamWriter(articlePath))
            using (JsonWriter writer = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(writer, encryptedArticle);
            }
            MessageBox.Show("Отредактированная статья успешно записана в файл");
        }
    }
}
