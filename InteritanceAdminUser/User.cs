using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteritanceAdminUser
{
    internal class User: Profile
    {
        public int Age { get; set; }

        public User(string name, string surname,int age, string email, string password, UserRole userrole) : base(name, surname, email,password, userrole) 
        {
            

            
        }
    }
}
