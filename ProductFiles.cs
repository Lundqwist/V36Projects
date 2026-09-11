using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace V36Projects
{
    internal class ProductFiles
    {



        internal static bool WriteProductsToFile(List<string> products, string fileName)
        {
            bool success = false;
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(products, options);
            try
            {
                System.IO.File.WriteAllText(fileName, json);
                success = true;

                Console.SetCursorPosition(0, 14);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("File written successfully.");
                Console.ForegroundColor = ConsoleColor.White;

            }
            catch 
            {
                success = false;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            
            return success;
            
        }

        internal static List<string> ReadProductsFromFile(string fileName)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string readJson = System.IO.File.ReadAllText(fileName);
                var loaded = JsonSerializer.Deserialize<List<string>>(readJson, options);
                
                Console.SetCursorPosition(0, 14);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("File was succesfully loaded.");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                return loaded ?? new List<string>();
            }
            catch
            {

                Console.SetCursorPosition(0, 14);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error occurred while reading products from file.");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                return new List<string>();
            }

            

        }
    }
}
