using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redactor
{
    public static class Cypher
    {
        public static List<User> EncryptUsers(List<User> users)
        {
            return null;
        }

        public static List<User> DecryptUsers(List<User> users)
        {
            return null;
        }

        // Шифрование статьи
        public static List<string> EncryptArticles(List<string> articles)
        {
            StringBuilder builder = new StringBuilder();
            List<string> encryptedArticle = new List<string>();

            foreach(string item in articles)
            {
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

        public static List<string> DecryptArticles(List<string> articles)
        {
            StringBuilder builder = new StringBuilder();
            List<string> decryptedArticle = new List<string>();

            foreach (string item in articles)
            {
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
    }
}
