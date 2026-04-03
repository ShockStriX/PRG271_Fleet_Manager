using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Fleet_Manager
{
    internal class Program
    {
        static async Task Main(string[] args)
        {              
            login login = new login();

            bool isLoggedIn = login.loginPrompt();

            if (isLoggedIn)
            {
                Console.WriteLine("Main Menu Reference Comes Here");
                List<Vehicle> vehicles = await FileManager.loadVehicles();
                List<Job> jobs = await FileManager.loadJobs();
                List<Routes> routes = await FileManager.loadRoutes();
            }
            else
            {
                Console.WriteLine("Access denied. Terminating...");
            } 
        }
    }
}
