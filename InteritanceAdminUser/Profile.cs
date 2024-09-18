using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteritanceAdminUser
{

   
    internal class Profile
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UserRole UserRole { get; set; }

        public Profile( string name, string surname, string email, string password, UserRole userRole)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            UserRole = userRole;    
        }

      
       
    }
}
