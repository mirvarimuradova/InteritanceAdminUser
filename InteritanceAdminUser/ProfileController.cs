using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteritanceAdminUser
{
    internal class ProfileController
    {
        public static ArrayList Users { get; set; } = null!;

        public ProfileController(Profile admin, Profile user)
        {
            Users = new ArrayList() { user,admin };


        }
        public static UserRole SignIn(string email, string password)
        {

            foreach (Profile user in Users)
            {

                if (user.Email == email && user.Password == password)
                {
                    return user.UserRole;
                }
            }
            return UserRole.None;
        }
        public static void SignUp(Profile user)
        {
            Users.Add(user);
        }

        public static void ShowAllUser(){
           
            foreach (Profile user in Users)
            {
                  
                if(user.UserRole== UserRole.Admin)
                {
                    Console.WriteLine($"Name: {user.Name}");
                    Console.WriteLine($"Surname: {user.Surname}");
                }

             }

                
             

         }
    }
}
