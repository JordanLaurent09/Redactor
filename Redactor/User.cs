using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redactor
{
    public enum Role
    {
        Admin,
        Author,
        Reader,
        Moderator
    }
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime BirthDate { get; set; }
        public Role Role { get; set; }
        public bool IsRedactor { get; set; } = false;
        public bool IsBlocked { get; set; } = false;
        public List<string> ArticleList { get; set; } = new List<string>();


        public User(string name)
        {
            Username = name;
        }
    }
}
