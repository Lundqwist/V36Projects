using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace V36Projects
{
    internal class MyProgram
    {
        private bool isRunning = true;
        private int weekNumber;


        public MyProgram()
        {
            DateTime date = DateTime.Now; // Current date
            CultureInfo cultureInfo = new CultureInfo("en-US");
            Calendar calendar = cultureInfo.Calendar;

            CalendarWeekRule rule = cultureInfo.DateTimeFormat.CalendarWeekRule;
            DayOfWeek firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;
            weekNumber = calendar.GetWeekOfYear(date, rule, firstDayOfWeek);
        }


        public void Run()
        {
            while (isRunning)
            {
                PrintMenu();
            }
        }


        public void PrintMenu()
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
            Console.WriteLine("*  Level Code                    option     *");
            Console.WriteLine("*  Level 1                         1        *");
            Console.WriteLine("*  Level 2                         2        *");
            Console.WriteLine("*  Level 3                         3        *");
            Console.WriteLine("*  Level 4                         4        *");
            Console.WriteLine("*  Level 5                         5        *");
            Console.WriteLine("*                                           *");
            Console.WriteLine("*  Exit program                    0        *");
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

                //Console.SetCursorPosition(0, 18);
                //Console.Write("                                                       ");
                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.SetCursorPosition(0, 18);
                //Console.WriteLine("Valid selection. GLHF!");

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
                    case "5":
                        Level5();
                        break;
                    case "0":
                        isRunning = false;
                        Console.WriteLine("\n\n");
                        break;
                    default:
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

        public void Level1()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************************");
            Console.Write($"*  Welcome to the v.{weekNumber}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Level 1              ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*");
            Console.WriteLine("*********************************************");


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            Console.Clear();
        }

        public void Level2()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************************");
            Console.Write($"*  Welcome to the v.{weekNumber}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Level 2              ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*");
            Console.WriteLine("*********************************************");


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            Console.Clear();
        }

        public void Level3()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************************");
            Console.Write($"*  Welcome to the v.{weekNumber}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Level 3              ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*");
            Console.WriteLine("*********************************************");


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            Console.Clear();
        }

        public void Level4()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************************");
            Console.Write($"*  Welcome to the v.{weekNumber}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Level 4              ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*");
            Console.WriteLine("*********************************************");


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            Console.Clear();
        }

        public void Level5()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************************");
            Console.Write($"*  Welcome to the v.{weekNumber}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Level 5              ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*");
            Console.WriteLine("*********************************************");


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
