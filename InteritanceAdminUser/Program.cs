

using InteritanceAdminUser;
using System.Reflection.Emit;

User user = new User("Zehra", "Melikzade",20,"zarallo@gmail.com", "zahra2004",UserRole.User);




Admin admin = new Admin("Mirvari", "Muradova","mirvarimuradova@gmail.com", "mirvari2003",UserRole.Admin);

ProfileController controller1 = new ProfileController(admin,user);


label:

Console.Clear();
Console.WriteLine("Choose a section: \n" +
    "1.Sign In\n" +
    "2.Sign Up\n" +
    "3.Show all user");

string section = Console.ReadLine() ?? "Unknown";

if (section == "1")
{
    Console.Write(" Email: ");
    string email = Console.ReadLine() ?? "Unknown";

    Console.Write("Password: ");
    string password = Console.ReadLine() ?? "Unknown";

    UserRole role = ProfileController.SignIn(email, password);

    if (role == UserRole.User)
    {
        foreach (Profile profile in ProfileController.Users)
        {
            if (profile.Email == email && profile.Password == password)
            {
                Console.WriteLine($"Name: {profile.Name}");
                Console.WriteLine($"Surname: {profile.Surname}");
              
            }


        }

        Console.WriteLine("Do you want to continue?y/n");

        string restart = Console.ReadLine() ?? "Unknown";

        if (restart == "y")
        {
            goto label;
        }
        else if (restart == "n")
        {
            Console.WriteLine("The process is finished!");
        }
    }

    else if (role == UserRole.Admin)
    {

        foreach (Profile profile in ProfileController.Users)
        {
            if (profile.Email == email && profile.Password == password)
            {
                Console.WriteLine($"Name: {profile.Name}");
                Console.WriteLine($"Surname: {profile.Surname}");
                  
            }

        }

       
    }
    Console.WriteLine("Do you want to continue?y/n");

    string restartt = Console.ReadLine() ?? "Unknown";

    if (restartt == "y")
    {
        goto label;
    }
    else if (restartt == "n")
    {
        Console.WriteLine("The process is finished!");
    }
}
else

    if (section == "2")
    {
        Console.WriteLine(" Enter datas of profile:\n");

        Console.Write("Name: ");
        string name = Console.ReadLine() ?? "unknown";

        Console.Write("Surname: ");
        string surname = Console.ReadLine() ?? "unknown";

        Console.Write("Email: ");
        string gmail = Console.ReadLine() ?? "unknown";

        Console.Write("Password: ");
        string passwordd = Console.ReadLine() ?? "unknown";

    roleagain:
        Console.WriteLine("Userrole:\n" +
            "1.User\n" +
            "2.Admin");
        string rolenum = Console.ReadLine() ?? "unknown";
        if (rolenum == "1")
        {
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());


            User newuser = new User(name, surname, age, gmail, passwordd, UserRole.User);
            ProfileController.SignUp(newuser);
            goto label;

        }

        else if (rolenum == "2")
        {
            Admin newadmin = new Admin(name, surname, gmail, passwordd, UserRole.Admin);
            ProfileController.SignUp(newadmin);
            goto label;
        }
        else
        {
            Console.WriteLine("wrong value");
            goto roleagain;
        }
    }
else if(section == "3")
{
    ProfileController.ShowAllUser();


}

