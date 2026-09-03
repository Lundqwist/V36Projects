using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
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
            }
            catch 
            {
                success = false;
            }
            
            return success;
            
        }

        internal static List<string> ReadProductsFromFile(string fileName)
        {
            
            var options = new JsonSerializerOptions { WriteIndented = true };
            string readJson = System.IO.File.ReadAllText(fileName);
            var loaded = JsonSerializer.Deserialize<List<string>>(readJson, options);
            


            return loaded ?? new List<string>();
        }
    }
}
