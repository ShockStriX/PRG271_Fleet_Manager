using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fleet_Manager
{
    internal class FileManager
    {
        public static void loadFiles()
        {
            try
            {
                StreamReader sr = new StreamReader(@".\Vehicles.txt");

                sr.ReadLine();

                string line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block");
            }
        }
    }
}
