using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteritanceAdminUser
{
    internal class Admin:Profile
    {
        public Admin(string name , string surname, string email, string password, UserRole userrole):base(name, surname, email, password, userrole )
        {
            

        }
    }
}
