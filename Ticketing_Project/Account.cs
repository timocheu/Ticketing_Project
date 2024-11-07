using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_Project
{
    public class Account
    {
        readonly private string name;
        readonly private string email;
        readonly private string password;

        public Account(string _Name, string _Email, String _Password)
        {
            name = _Name;
            email = _Email;
            password = _Password;
        }

        public string Name {
            get {return name;}
        }

        public string Email{
            get {return email;}
        }

        public string Password {
            get {return password;}
        }
    }
}
