using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Fleet_Manager
{
    internal class FileManager
    {
        public static async Task<List<Vehicle>> loadVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            try
            {
                StreamReader srVehicles = new StreamReader(@".\Vehicles.txt");

                await srVehicles.ReadLineAsync(); //Skips headers

                string line = await srVehicles.ReadLineAsync();

                while (line != null)
                {
                    string[] values = line.Split(',');

                    string vehicleType = values[3]; //This checks the vehicle type from the csv file and used the correct child class to create the vehicle. Making use of inheritance & polymorphism
                    Vehicle v;

                    switch (vehicleType)
                    {
                        case "Bakkie":
                            v = new Bakkie(
                                int.Parse(values[0]),   //VehicleID
                                int.Parse(values[1]),   //mileage
                                int.Parse(values[2]),   //currentJob
                                int.Parse(values[4]),   //year
                                values[5],              //brand
                                values[6],              //model
                                values[7]);             //licensePlate
                            break;

                        case "Van":
                            v = new Van(
                                int.Parse(values[0]),   
                                int.Parse(values[1]),   
                                int.Parse(values[2]),   
                                int.Parse(values[4]),   
                                values[5],             
                                values[6],              
                                values[7]);
                            break;

                        case "Workhorse":
                            v = new Workhorse(
                                int.Parse(values[0]),
                                int.Parse(values[1]),
                                int.Parse(values[2]),
                                int.Parse(values[4]),
                                values[5],
                                values[6],
                                values[7]);
                            break;

                        default:
                            Console.WriteLine($"Unknown vehicle type: {vehicleType}, skipping...");
                            line = await srVehicles.ReadLineAsync();
                            continue;
                    }

                    vehicles.Add(v);
                    line = await srVehicles.ReadLineAsync();
                }

                srVehicles.Close();
            }
            catch (Exception e)     //Exception handling in case the csv files are missing or removed
            {
                Console.WriteLine("Exception: " + e.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Vehicles loaded successfully!");
            }
            return vehicles;
        }

        public static async Task<List<Job>> loadJobs()
        {
            List<Job> jobs = new List<Job>();

            try
            {
                StreamReader srJobs = new StreamReader(@".\Jobs.txt");

                await srJobs.ReadLineAsync();

                string line = await srJobs.ReadLineAsync();

                while (line != null)
                {
                    string[] values = line.Split(',');

                    Job j = new Job(
                        int.Parse(values[0]),   //JobID
                        int.Parse(values[1]));  //currentRoute

                    jobs.Add(j);
                    line = await srJobs.ReadLineAsync();
                }

                srJobs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Jobs loaded successfully!");
            }
            return jobs;
        }

        public static async Task<List<Routes>> loadRoutes()
        {
            List<Routes> routes = new List<Routes>();

            try
            {
                StreamReader srRoutes = new StreamReader(@".\Routes.txt");

                srRoutes.ReadLine();

                string line = await srRoutes.ReadLineAsync();

                while (line != null)
                {
                    string[] values = line.Split(',');

                    Routes r = new Routes(
                        int.Parse(values[0]),       //RouteID
                        values[1],                  //Location 1
                        values[2],                  //Location 2
                        values[3],                  //Location 3
                        values[4],                  //Location 4
                        values[5],                  //Location 5
                        int.Parse(values[6]),       //Total Kilometres
                        double.Parse(values[7], System.Globalization.CultureInfo.InvariantCulture));   
                        //Average Kilometres

                    routes.Add(r);
                    line = await srRoutes.ReadLineAsync();
                }
                srRoutes.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Routes loaded successfully!");
            }
            return routes;
        }
    }
}
