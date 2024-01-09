using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;

namespace Redactor.RoleOfUsers
{
    public partial class AuthorForm : Form
    {
        private static List<string> _paragraphs = new List<string>();
        private static List<User> _users;

        public User CurrentUser { get; set; }

        public AuthorForm(User user)
        {
            InitializeComponent();
            CurrentUser = user;

            List<string> articles = GetArticles();

            if(articles.Count > 0)
            {
                //HeaderTB.Enabled = false;
                //UnderHeaderTB.Enabled = false;
                //ParagraphTB.Enabled = false;
                AddParagraphBTN.Enabled = false;
            }

            foreach(string item in articles)
            {
                ArticleListLB.Items.Add(item);
            }

            AddHeaderBTN.Enabled = false;
            AddUnderheaderBTN.Enabled = false;
            AddNewArticleBTN.Enabled = false;
            saveChangesBTN.Enabled = false;
        }

        // Добавить новую статью
        private void AddNewArticleBTN_Click(object sender, EventArgs e)
        {
            List<string> article = new List<string>();
            string articlePath = $"{Directory.GetCurrentDirectory()}\\AuthorArticles\\{CurrentUser.Username}";

            article.Add(ArticleNameTB.Text);
            article.Add(HeaderTB.Text);
            article.Add(UnderHeaderTB.Text);

            foreach(string line in WholeArticleTB.Lines)
            {
                article.Add(line);
            }

            // Шифрование статьи

            List<string> encryptedArt = Cypher.EncryptArticles(article);

            // Сохранение статьи в файл

            JsonSerializer serializer = new JsonSerializer();

            using(StreamWriter sw = new StreamWriter($"{articlePath}\\{ArticleNameTB.Text}.json"))
                using(JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, encryptedArt);
            }

            _users = GetUsers();

            foreach(User user in _users)
            {
                if(user.Username == CurrentUser.Username)
                {
                    user.ArticleList.Add(ArticleNameTB.Text);
                }
            }

            RewriteUsers(_users);

            CurrentUser.ArticleList.Add(ArticleNameTB.Text);


            ArticleNameTB.Clear();
            HeaderTB.Clear();
            UnderHeaderTB.Clear();
            WholeArticleTB.Clear();
            ArticleListLB.Items.Clear();
            _paragraphs.Clear();
            ArticleListLB.Enabled = true;
            HeaderTB.Enabled = false;
            UnderHeaderTB.Enabled = false;
            AddParagraphBTN.Enabled = false;
            AddNewArticleBTN.Enabled = false;
            CreateArticleBTN.Enabled = true;
            EditAnArticleBTN.Enabled = true;



            List<string> articles = GetArticles();
            foreach (string item in articles)
            {
                ArticleListLB.Items.Add(item);
            }

        }

        // Получение списка статей конкретного автора
        private List<string> GetArticles()
        {
            return CurrentUser.ArticleList;
        }

        // Добавление нового абзаца в статью
        private void AddParagraphBTN_Click(object sender, EventArgs e)
        {
            if (ParagraphTB.Text != string.Empty)
            {
                _paragraphs.Add(ParagraphTB.Text);

                WholeArticleTB.Lines = _paragraphs.ToArray();

                ParagraphTB.Text = string.Empty;
            }
            if(HeaderTB.Text != string.Empty && UnderHeaderTB.Text != string.Empty && WholeArticleTB.Text != string.Empty)
            {
                AddNewArticleBTN.Enabled = true;
                HeaderTB.Enabled = false;
                UnderHeaderTB.Enabled = false;
            }
        }

        // Появление статьи на форме при выборе ее из списка статей

        private void ArticleListLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> temp = new List<string>();
            List<string> articleText;

            ArticleNameTB.Text = ArticleListLB.SelectedItem.ToString();

            string articlePath = $"{Directory.GetCurrentDirectory()}\\AuthorArticles\\{CurrentUser.Username}\\{ArticleNameTB.Text}.json";

            string article = File.ReadAllText(articlePath);

            articleText = JsonConvert.DeserializeObject<List<string>>(article);

            // Дешифровка статьи

            List<string> decryptedArticle = Cypher.EncryptArticles(articleText);

            HeaderTB.Text = decryptedArticle[1];
            UnderHeaderTB.Text = decryptedArticle[2];
            
            for(int i = 3; i < articleText.Count; i++)
            {
                temp.Add(decryptedArticle[i]);
            }

            WholeArticleTB.Lines = temp.ToArray();
        }

        // Очистка формы для написания новой статьи
        private void CreateArticleBTN_Click(object sender, EventArgs e)
        {
            ArticleNameTB.Clear();
            HeaderTB.Clear();
            UnderHeaderTB.Clear();
            WholeArticleTB.Clear();
            HeaderTB.Enabled = true;
            UnderHeaderTB.Enabled = true;
            ParagraphTB.Enabled = true;
            EditAnArticleBTN.Enabled = false;
            CreateArticleBTN.Enabled = false;
            AddParagraphBTN.Enabled = true;
            ArticleListLB.Enabled = false;
            
        }

        private void EditAnArticleBTN_Click(object sender, EventArgs e)
        {
            ArticleNameTB.Enabled = false;
            CreateArticleBTN.Enabled = false;
            EditAnArticleBTN.Enabled = false;
            HeaderTB.Enabled = false;
            UnderHeaderTB.Enabled = false;
            AddHeaderBTN.Enabled = true;
            AddUnderheaderBTN.Enabled = true;
            AddParagraphBTN.Enabled = true;
        }


        // Получение списка пользователей
        private List<User> GetUsers()
        {
            List<User> users;

            string _userDataPath = Directory.GetCurrentDirectory() + "\\users.json";

            string usersInfo = File.ReadAllText(_userDataPath);

            users = Cypher.EncryptUsers(JsonConvert.DeserializeObject<List<User>>(usersInfo));

            return users;
        }


        // Перезапись списка пользователей в связи с изменением информации о статьях

        private void RewriteUsers(List<User> users)
        {
            List<User> encryptUsers = Cypher.EncryptUsers(users);
            string fileName = $"{Directory.GetCurrentDirectory()}\\users.json";
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, encryptUsers);
            }
        }
    }
}
