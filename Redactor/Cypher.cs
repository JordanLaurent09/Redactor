using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redactor
{
    public static class Cypher
    {
        // Шифрование списка пользователей
        public static List<User> EncryptUsers(List<User> users)
        {
            List<User> encryptUsers = new List<User>();

            // Перебор в цикле объектов Users
            foreach(User user in users)
            {
                int id = user.Id ^ 5;
                string username = EncryptLine(user.Username);
                string firstName = EncryptLine(user.FirstName);
                string secondName = EncryptLine(user.SecondName);
                string email = EncryptLine(user.Email);
                string password = EncryptLine(user.Password);
                DateTime regDate = user.RegistrationDate;
                DateTime birthDate = user.BirthDate;
                Role role = user.Role;
                bool isRedactor = user.IsRedactor;
                bool isBlocked = user.IsBlocked;
                List<string> articles = EncryptArticles(user.ArticleList);

                User encryptUser = new User(username, firstName, secondName, email, password, birthDate, role);
                encryptUser.Id = id;
                encryptUser.RegistrationDate = regDate;
                encryptUser.IsRedactor = isRedactor;
                encryptUser.IsBlocked = isBlocked;
                encryptUser.ArticleList = articles;

                encryptUsers.Add(encryptUser);
            }

            return encryptUsers;
        }

        // Дешифрование списка пользователей
        public static List<User> DecryptUsers(List<User> users)
        {
            List<User> decryptUsers = new List<User>();

            // Перебор в цикле объектов Users
            foreach (User user in users)
            {
                int id = user.Id ^ 5;
                string username = EncryptLine(user.Username);
                string firstName = EncryptLine(user.FirstName);
                string secondName = EncryptLine(user.SecondName);
                string email = EncryptLine(user.Email);
                string password = EncryptLine(user.Password);
                DateTime regDate = user.RegistrationDate;
                DateTime birthDate = user.BirthDate;
                Role role = user.Role;
                bool isRedactor = user.IsRedactor;
                bool isBlocked = user.IsBlocked;
                List<string> articles = EncryptArticles(user.ArticleList);

                User decryptUser = new User(username, firstName, secondName, email, password, birthDate, role);
                decryptUser.Id = id;
                decryptUser.RegistrationDate = regDate;
                decryptUser.IsRedactor = isRedactor;
                decryptUser.IsBlocked = isBlocked;
                decryptUser.ArticleList = articles;

                decryptUsers.Add(decryptUser);
            }

            return decryptUsers;
        }

        // Шифрование статьи
        public static List<string> EncryptArticles(List<string> articles)
        {          
            List<string> encryptedArticle = new List<string>();

            foreach(string item in articles)
            {
                StringBuilder builder = new StringBuilder();
                char[] chars = item.ToCharArray();
                byte[] bytes = new byte[chars.Length];

                for(int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = (byte)chars[i];
                }

                int[] encryptedBites = new int[chars.Length];

                for(int i = 0; i < encryptedBites.Length; i++)
                {
                    encryptedBites[i] = bytes[i] ^ 5;
                }

                char[] encryptedChars = new char[chars.Length];
                for (int i = 0; i < encryptedChars.Length; i++)
                {
                    encryptedChars[i] = (char)encryptedBites[i];
                    builder.Append(encryptedChars[i]);
                }

                string encryptedText = builder.ToString();

                encryptedArticle.Add(encryptedText);
            }

            return encryptedArticle;
        }


        // Дешифрование статьи
        public static List<string> DecryptArticles(List<string> articles)
        {            
            List<string> decryptedArticle = new List<string>();

            foreach (string item in articles)
            {
                StringBuilder builder = new StringBuilder();
                char[] chars = item.ToCharArray();
                byte[] bytes = new byte[chars.Length];

                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = (byte)chars[i];
                }

                int[] encryptedBites = new int[chars.Length];

                for (int i = 0; i < encryptedBites.Length; i++)
                {
                    encryptedBites[i] = bytes[i] ^ 5;
                }

                char[] encryptedChars = new char[chars.Length];
                for (int i = 0; i < encryptedChars.Length; i++)
                {
                    encryptedChars[i] = (char)encryptedBites[i];
                    builder.Append(encryptedChars[i]);
                }

                string encryptedText = builder.ToString();

                decryptedArticle.Add(encryptedText);
            }

            return decryptedArticle;
        }

        // Шифровка/дешифровка строчки

        public static string EncryptLine(string line)
        {
            StringBuilder builder = new StringBuilder();
            char[] chars = line.ToCharArray();
            byte[] bytes = new byte[chars.Length];

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)chars[i];
            }

            int[] encryptedBites = new int[chars.Length];

            for (int i = 0; i < encryptedBites.Length; i++)
            {
                encryptedBites[i] = bytes[i] ^ 5;
            }

            char[] encryptedChars = new char[chars.Length];
            for (int i = 0; i < encryptedChars.Length; i++)
            {
                encryptedChars[i] = (char)encryptedBites[i];
                builder.Append(encryptedChars[i]);
            }

            string encryptedText = builder.ToString();

            return encryptedText;
        }
    }
}
