using System;

namespace firstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Console";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What is your name?");

            Console.ForegroundColor = ConsoleColor.White;
            string name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello " + name + ", nice to meet you");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("How old are you?");

            Console.ForegroundColor = ConsoleColor.White;
            int age = Convert.ToInt16(Console.ReadLine());

            if(age > 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are older " + Convert.ToString(age - 30) + " years than me");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are younger " + Convert.ToString(30 - age) + " years than me");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
