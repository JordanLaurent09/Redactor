using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redactor
{
    public class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public string Condition { get; set; }

        public User(string name)
        {
            Username = name;
        }
    }
}
