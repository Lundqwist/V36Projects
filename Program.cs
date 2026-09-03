using System.Globalization;

namespace V36Projects
{
    internal class Program
    {
        public static bool isRunning = true;
        static void Main(string[] args)
        {
            MyProgram myProgram = new MyProgram();
           
            myProgram.Run();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThanks for playing!");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();



        }

        
    }
}
