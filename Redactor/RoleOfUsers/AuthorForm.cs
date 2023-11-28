using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Redactor.RoleOfUsers
{
    public partial class AuthorForm : Form
    {
        private static List<string> _paragraphs = new List<string>();

        public User CurrentUser { get; set; }

        public AuthorForm(User user)
        {
            InitializeComponent();
            CurrentUser = user;

            List<string> articles = GetArticles();

            foreach(string item in articles)
            {
                ArticleListLB.Items.Add(item);
            }

        }

        private void AddNewArticleBTN_Click(object sender, EventArgs e)
        {
            string userPath = Directory.GetCurrentDirectory() + "\\" + CurrentUser.Username;

            string articleTitle = ArticleNameTB.Text;

            string[] wholeArticle = WholeArticleTB.Lines;

            StreamWriter writer = new StreamWriter(userPath + "\\" + articleTitle + ".txt");
            foreach(string item in wholeArticle)
            {
                writer.WriteLine(item);
            }
            writer.Close();
            ArticleNameTB.Clear();
        }

        private List<string> GetArticles()
        {
            string userPath = Directory.GetCurrentDirectory() + "\\" + CurrentUser.Username;
            DirectoryInfo dir = new DirectoryInfo(userPath);
            List<string> articlesList = new List<string>();
            FileInfo[] files = dir.GetFiles();
            
            for(int i = 0; i < files.Length; i++)
            {
                articlesList.Add(files[i].Name.Substring(0, files[i].Name.Length - 4));
            }
            return articlesList;
        }

        private void AddParagraphBTN_Click(object sender, EventArgs e)
        {
            if (ParagraphTB.Text != string.Empty)
            {
                _paragraphs.Add(ParagraphTB.Text);

                WholeArticleTB.Lines = _paragraphs.ToArray();

                ParagraphTB.Text = string.Empty;
            }
        }
    }
}
