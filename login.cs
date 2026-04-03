using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fleet_Manager
{
    internal class login
    {
        private const string ValidUsername = "admin";
        private const string ValidPassword = "fleet123";

        public bool loginPrompt()
        {
            int loginAttempts = 2;
            Console.WriteLine("=== Welcome to RoadLink ===");
            Console.WriteLine("Please enter your credentials");
            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = readMaskedPassword();

            if (username == ValidUsername && password == ValidPassword && loginAttempts > 0)
            {
                Console.WriteLine("\nLogin Successful. Welcome!\n");
                return true;
            }
            else while(loginAttempts>0)
            {
                Console.WriteLine("\nYour username and/or password was incorrect, please try again...\nYou have {0} attempts remaining\n", loginAttempts);
                Console.Write("Username: ");
                username = Console.ReadLine();
                Console.Write("Password: ");
                password = readMaskedPassword();

                if (username == ValidUsername && password == ValidPassword)
                {
                    Console.WriteLine("\nLogin Successful. Welcome!\n");
                    return true;
                }
                else
                {
                    loginAttempts--;
                }
            }
            return false;
        }

        private string readMaskedPassword() //Hides the password the user enters
        {
            string password = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(intercept: true);

                if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Substring(0, password.Length - 1);
                    Console.Write("\b \b");
                }
            }
            while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return password;
        }

    }
}


