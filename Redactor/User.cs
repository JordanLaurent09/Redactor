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

        public User()
        {

        }

        public User(string name)
        {
            Username = name;
        }

        public User(string username, string firstName, string secondName, string email, string password, DateTime birthDate, Role role)
        {
            Username = username;
            FirstName = firstName;
            SecondName = secondName;
            Email = email;
            Password = password;
            BirthDate = birthDate;
            Role = role;
        }
    }
}
