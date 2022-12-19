using System.ComponentModel.Design;
/*
 * Program Name: Log In Account Manager
 * Programmer: Gabriel Healy
 * Date: 12/19/2022
 *
 * Description: This is a program where
 * people create accounts and log in to the program.
 * It saves the accounts into the computer.
 */

Console.WriteLine("Press 1 to Login");
Console.WriteLine("Press 2 to create Users");

int selection = int.Parse(Console.ReadLine());

Console.WriteLine();

void CreateUsers()
{
    bool isLooping = true;

    List<User> users = new List<User>();
    List<Guest> guests = new List<Guest>();
    List<Admin> admins = new List<Admin>();

    while (isLooping)
    {
        Console.WriteLine("Enter a username: ");
        string un = Console.ReadLine();


        Console.WriteLine("Enter a password: ");
        string pw = Console.ReadLine();


        Console.WriteLine("Press 1 for a Generic User.");
        Console.WriteLine("Press 2 for a Guest User.");
        Console.WriteLine("Press 3 for an Admin User.");
        int selection = int.Parse(Console.ReadLine());

        Console.Clear();

        if (selection == 1)
        {
            users.Add(new User(un, pw));
            Console.WriteLine(un + " has been created as a Generic User");
        }
        else if (selection == 2)
        {
            guests.Add(new Guest(un, pw));
            Console.WriteLine(un + " has been created as a Guest User");
        }
        else if (selection == 3)
        {
            admins.Add(new Admin(un, pw));
            Console.WriteLine(un + " has been created as an Admin User");
        }
        else
        {
            Console.WriteLine("Invalid Selection. No user created.");
        }

        Console.WriteLine("Users: ");
        foreach (User user in users)
        {
            Console.WriteLine(user.username);
        }

        Console.WriteLine("Guests: ");
        foreach (Guest guest in guests)
        {
            Console.WriteLine(guest.username);
        }

        Console.WriteLine("Admins: ");
        foreach (Admin admin in admins)
        {
            Console.WriteLine(admin.username);
        }
    }
}

void Login()
{
    Console.WriteLine("Login");
}