using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace V36Projects
{
    internal class MyProgram
    {
        private bool isRunning = true;
        private int weekNumber;

        // Constructor to initialize the MyProgram class and calculate the current week number based on the current date.
        public MyProgram()
        {
            DateTime date = DateTime.Now; // Current date
            CultureInfo cultureInfo = new CultureInfo("en-US");
            Calendar calendar = cultureInfo.Calendar;

            CalendarWeekRule rule = cultureInfo.DateTimeFormat.CalendarWeekRule;
            DayOfWeek firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;
            weekNumber = calendar.GetWeekOfYear(date, rule, firstDayOfWeek);
        }

        // Method to run the program, continuously displaying the menu until the user chooses to exit.
        public void Run()
        {
            while (this.isRunning)
            {
                Menu();
            }
        }


        /* Printing Menu and handling user input for menu selection. 
         * The menu displays the current week number and provides options for different levels of product list management. 
         * It also handles invalid input and allows the user to exit the program.
         */
        
        public void Menu()
        {
            DateTime date = DateTime.Now; // Current date
            CultureInfo cultureInfo = new CultureInfo("en-US");
            Calendar calendar = cultureInfo.Calendar;

            CalendarWeekRule rule = cultureInfo.DateTimeFormat.CalendarWeekRule;
            DayOfWeek firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;
            weekNumber = calendar.GetWeekOfYear(date, rule, firstDayOfWeek);


            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************************");
            Console.WriteLine($"* Welcome to the v.{weekNumber} Projects!             *");
            Console.WriteLine("*********************************************");
            Console.WriteLine("*                                           *");
            Console.WriteLine("*  1. PRODUCT LIST MANAGER LEVEL 1          *");
            Console.WriteLine("*  2. PRODUCT LIST MANAGER LEVEL 2          *");
            Console.WriteLine("*  3. PRODUCT LIST MANAGER LEVEL 3          *");
            Console.WriteLine("*  4. PRODUCT LIST MANAGER LEVEL 4          *");
            Console.WriteLine("*                                           *");
            Console.WriteLine("*  'exit'     Exit program                  *");
            Console.WriteLine("*                                           *");
            Console.WriteLine("*********************************************");
            Console.WriteLine();

            Console.SetCursorPosition(15, 16);
            Console.Write("              ");
            Console.SetCursorPosition(0, 16);
            Console.Write(" Please enter number: ");

            Console.SetCursorPosition(22, 16);
            string input = Console.ReadLine().Trim();



            if (int.TryParse(input, out int number))
            {

                Console.ForegroundColor = ConsoleColor.White;

                switch (input)
                {
                    case "1":
                        Level1();
                        break;

                    case "2":
                        Level2();
                        break;

                    case "3":
                        Level3();
                        break;

                    case "4":
                        Level4();
                        break;

                    case "42":
                        isRunning = false;
                        Console.WriteLine("\n\n");
                        break;

                    default:
                        Console.SetCursorPosition(0, 18);
                        Console.Write("                                                       ");
                        
                        Console.SetCursorPosition(0, 18);
                        
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid selection. Please try again.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
               
                }

            }
            else if (input.ToLower().Trim() == "exit")
            {

                this.isRunning = false;                         // Sets the class variable isRunning to false, which will exit the program.
            
            }
            else
            {
               
                Console.SetCursorPosition(0, 18);
                Console.Write("                                                       ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, 18);
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.ForegroundColor = ConsoleColor.White;
            
            }



        }

        public void Level1()
        {
            
            List<string> products = new List<string>();
            string input = string.Empty;
            bool isRunning = true;
            int numberOfProducts = 0;

            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("  PRODUCT LIST MANAGER - LEVEL 2");
            Console.WriteLine("--------------------------------------------" + "\n");

            while (isRunning)
            {

                Console.WriteLine("* Enter products by name.\nWhen you are done, type 'Done'.");
                Console.WriteLine();

                Console.SetCursorPosition(0, 6);
                Console.WriteLine("                                                 ");
                Console.SetCursorPosition(0, 6);
                Console.Write("Enter Product: ");
                input = Console.ReadLine().Trim();

                if (input.ToLower().Trim() != "done")
                {
                
                    products.Add(input);
                    numberOfProducts++;
                    Console.SetCursorPosition(1, 8);
                    Console.Write($"Number of products entered: {numberOfProducts}");
                
                }
                else
                {
                    
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("\nYou have entered the following products:");
                    foreach (var product in products)
                    {
                    
                        Console.WriteLine($"- {product}");
                    
                    }
                    isRunning = !true;
                
                }
            }


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            Console.Clear();

        }

        public void Level2()
        {
            
            List<string> products = new List<string>();
            string input = string.Empty;
            bool isRunning = true;
            int numberOfProducts = 0;

            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("  PRODUCT LIST MANAGER - LEVEL 2");
            Console.WriteLine("--------------------------------------------" + "\n");

            Console.Write("Enter products by name.\nWhen you are done, type '");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Exit");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("'." + "\n");

            while (isRunning)     // using local version of isRunning to control the loop, so that the class variable isRunning can be used to exit the program from the menu.
            {

                Console.SetCursorPosition(0, 6);
                Console.WriteLine("                                                 ");
                Console.SetCursorPosition(0, 6);
                Console.Write("Enter Product: ");
                input = Console.ReadLine().Trim();

                if (input.ToLower().Trim() != "exit")
                {
                    
                    products.Add(input);
                    numberOfProducts++;
                    Console.SetCursorPosition(1, 8);
                    Console.Write($"Number of products entered: {numberOfProducts}");
                
                }
                else
                {
                    
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("\nYou have entered the following products in alphabetical order:\nThe swedish 'åäö' counts as 'a' and 'o'\n");

                    products.Sort();
                    foreach (var product in products)
                    {
                        
                        Console.WriteLine($"- {product}");
                    
                    }

                    isRunning = !true;
                
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            Console.Clear();
        
        }

        public void Level3()
        {
            
            List<string> products = new List<string>();
            string input = string.Empty;
            bool isRunning = true;

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("  PRODUCT LIST MANAGER - LEVEL 3");
            Console.WriteLine("--------------------------------------------" + "\n");

            Console.Write("Enter product names (format: 'name-number').\nType '");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Exit");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("' to finish.\n");


            while (isRunning)
            {

                Console.SetCursorPosition(0, 6);
                Console.WriteLine("                                                 ");
                
                Console.SetCursorPosition(0, 6);
                Console.Write("Enter Product: ");
                
                input = Console.ReadLine().Trim();

                if (input.ToLower() == "exit")
                {

                    if (products.Count > 0)
                    {
                        
                        Console.Clear();
                        products.Sort();

                        Console.WriteLine("\nSorted valid products:\nThe swedish 'åä' sorts as 'a' and 'ö' as 'o'\n");
                        foreach (var product in products)
                        {
                            
                            Console.WriteLine($"- {product}");
                        
                        }
                    }
                    else
                    {
                        
                        Console.WriteLine("No products were entered.");
                    }

                    break;

                }
                if (input.Equals(string.Empty))
                {
                    
                    Console.SetCursorPosition(0, 18);
                    Console.Write("                                                       ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(0, 18);
                    Console.WriteLine("Input cannot be empty.");
                    Console.ForegroundColor = ConsoleColor.White;
                
                }
                else
                {
                    
                    if (CheckProduct(input))        // Calling hte method CheckProduct to validate the input format. If valid, the product is added to the list.
                    {
                        products.Add(input);
                    }
                
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            Console.Clear();
        
        }

        public void Level4()
        {
            
            List<string> products = new List<string>();
            string input = string.Empty;
            bool isRunning = true;

            while (isRunning)
            {
                
                Console.Clear();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("  PRODUCT LIST MANAGER - LEVEL 4");
                Console.WriteLine("--------------------------------------------" + "\n");

                Console.WriteLine("  1. Add Product");
                Console.WriteLine("  2. View Products");
                Console.WriteLine("  3. Search Product");
                Console.WriteLine("  4. Delete Product");
                Console.WriteLine("  5. Statistics");
                Console.WriteLine("  6. Save to file 'MyProducts.json'");
                Console.WriteLine("  7. Load from file 'MyProducts.json'");
                Console.WriteLine("\n  9. Exit\n");

                //Console.SetCursorPosition(0, 12);
                //Console.WriteLine("                               ");
                Console.SetCursorPosition(0, 14);
                Console.WriteLine("                               ");

                Console.SetCursorPosition(0, 14);
                Console.Write("Choice: ");

                input = Console.ReadLine().Trim();



                if (input.All(char.IsDigit))
                {

                    switch (input)
                    {
                        
                        case "1":                                                   // Add Product
                            Console.SetCursorPosition(0, 14);
                            Console.WriteLine("                               ");
                            Console.SetCursorPosition(0, 14);
                            Console.Write("Enter Product: ");
                            input = Console.ReadLine().Trim();
                            
                            if (CheckProduct(input))
                            {
                                
                                products.Add(input);

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(input + " Added to list.");
                                Console.ForegroundColor = ConsoleColor.White;
                            
                            }

                            break;
                        
                        case "2":                                                   // View Products
                            Console.SetCursorPosition(0, 16);
                            products.Sort();
                            Console.WriteLine("List of products:");
                            
                            foreach (var product in products)
                            {
                                
                                Console.WriteLine($"- {product}");
                            
                            }

                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();

                            break;

                        case "3":                                                   // Search Product
                            Console.SetCursorPosition(0, 14);
                            Console.WriteLine("                               ");
                            Console.SetCursorPosition(0, 14);
                            Console.Write("Search: ");

                            input = Console.ReadLine().Trim();
                            bool found = false;

                            // Creates an object of the Regex class with a pattern that matches the input against the product string. The pattern checks for two cases:
                            Regex regex = new Regex($@"^{Regex.Escape(input)}-(\d+)$|^([a-zA-Z]+)-{Regex.Escape(input)}$");

                            Console.SetCursorPosition(0, 16);
                            foreach (var product in products)
                            {
                                // Without Regex, we can split the product string by the dash and check both parts
                                string[] parts = product.Split('-');

                                if (parts[0] == input || parts[1] == input)
                                {
                                    
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"Product found: {product} without Regex");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    found = true;
                                
                                }
                                
                                // With Regex, we can use a pattern to match the input against the product string
                                if(regex.IsMatch(product))
                                {
                                    
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"Product found: {product} with Regex");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    found = true;
                                
                                } 

                            }

                            if (!found)
                            {
                                
                                Console.SetCursorPosition(0, 16);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Product not found.");
                                Console.ForegroundColor = ConsoleColor.White;
                            
                            }

                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            break;

                        case "4":                                                                   // Delete Product
                            Console.SetCursorPosition(0, 14);
                            Console.Write("Delete: ");
                            input = Console.ReadLine().Trim();
                            found = false;

                            if (CheckProduct(input))
                            {

                                Console.SetCursorPosition(0, 16);

                                Console.WriteLine("Deleting product..." + input);
                                products.Remove(input);

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Product deleted.");
                                Console.ForegroundColor = ConsoleColor.White;
                                found = true;

                            }

                            if (!found)
                            {
                                
                                Console.SetCursorPosition(0, 16);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Product not found.");
                                Console.ForegroundColor = ConsoleColor.White;
                            
                            }

                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();

                            break;

                        case "5":                                                                   // Statistics
                            int lowestNumber = 0;
                            int highestNumber = 0;
                            int totalValue = 0;

                            Console.SetCursorPosition(0, 14);
                            Console.WriteLine("                               ");
                            Console.SetCursorPosition(0, 14);
                            Console.WriteLine($"Total number of products: {products.Count}");
                            
                            foreach (var product in products)
                            {
                                
                                string[] parts = product.Split('-');
                                
                                if (int.TryParse(parts[1], out int number))
                                {
                                    
                                    if (lowestNumber == 0 || number < lowestNumber)
                                    {
                                        
                                        lowestNumber = number;
                                    
                                    }
                                    if (number > highestNumber)
                                    {
                                        
                                        highestNumber = number;
                                    
                                    }
                                    totalValue += number;
                                
                                }
                            }   

                            Console.WriteLine("Lowest number: " + lowestNumber);
                            Console.WriteLine("Highest number: " + highestNumber);
                            Console.WriteLine("Average number: " + (products.Count > 0 ? (totalValue / products.Count) : 0));
                            
                            
                            
                            
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            
                            break;

                        case "6":                                                                           // Save to file 'MyProducts.json'
                            Console.SetCursorPosition(0, 14);
                            Console.WriteLine("                               ");
                            Console.SetCursorPosition(0, 14);
                            
                            if (ProductFiles.WriteProductsToFile(products, "MyProducts.json"))
                            {
                                
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("File saved.");
                                Console.ForegroundColor = ConsoleColor.White;
                            
                            }
                            else
                            {
                                
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Something broke!");
                                Console.ForegroundColor = ConsoleColor.White;
                            
                            }

                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();

                            break;

                        case "7":                                                                           // Load from file 'MyProducts.json'
                            products = ProductFiles.ReadProductsFromFile("MyProducts.json");
                            
                            break;
                        
                        case "9":                                                                           // Exit
                            isRunning = false;
                            
                            break;
                        
                        default:                                                                            // Invalid selection
                            Console.SetCursorPosition(0, 18);
                            Console.Write("                                                       ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(0, 18);
                            Console.WriteLine("Invalid selection. Please try again.");
                            Console.ForegroundColor = ConsoleColor.White;
                            
                            break;
                    
                    }


                }
                else
                {
                    
                    Console.SetCursorPosition(0, 18);
                    Console.Write("                                                       ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(0, 18);
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.ForegroundColor = ConsoleColor.White;
                
                }
            }

            Console.SetCursorPosition(0, 20);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Console.Clear();

        }

        // Method to check if the input product string is valid according to the specified format.
        private bool CheckProduct(string input)
        {
            bool valid = false;
            
            if (!input.Contains('-'))
            {
                
                Console.SetCursorPosition(0, 18);
                Console.Write("                                                       ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, 18);
                Console.WriteLine("Product must contain a dash (-).");
                Console.ForegroundColor = ConsoleColor.White;
            
            }
            else
            {
                
                string[] parts = input.Split('-');
                bool[] isValidFormat = { false, false };

                if (parts[0].All(char.IsLetter))
                {
                    
                    isValidFormat[0] = true;
                
                }
                else
                {
                    
                    Console.SetCursorPosition(0, 18);
                    Console.Write("                                                       ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(0, 18);
                    Console.WriteLine("The left side must contain letters only.");
                    Console.ForegroundColor = ConsoleColor.White;
                
                }


                if (parts[1].All(char.IsDigit))
                {
                    
                    if (int.TryParse(parts[1], out int version))
                    {

                        if (version <= 500 && version >= 200)
                        {

                            isValidFormat[1] = true;
                        
                        }
                        else
                        {
                            
                            Console.SetCursorPosition(0, 18);
                            Console.Write("                                                       ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(0, 18);
                            Console.WriteLine("The numeric part must be between 200 and 500.");
                            Console.ForegroundColor = ConsoleColor.White;
                        
                        }
                    }

                }
                else
                {
                    
                    Console.SetCursorPosition(0, 18);
                    Console.Write("                                                       ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(0, 18);
                    Console.WriteLine("The right side must contain numbers only.");
                    Console.ForegroundColor = ConsoleColor.White;
                
                }

                if (isValidFormat[0] && isValidFormat[1])
                {
                    
                    valid = true;

                }
            }

            return valid;
        
        }
    }
}