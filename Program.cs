using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fleet_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            login login = new login();

            bool isLoggedIn = login.loginPrompt();

            if (isLoggedIn)
            {
                Console.WriteLine("Main Menu Reference Comes Here");
            }
            else
            {
                Console.WriteLine("Access denied. Terminating...");
                
            }
        }
    }
}
