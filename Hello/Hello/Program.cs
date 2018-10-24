
using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello," + args[1]);
            int hoursOfSleep = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello" + name);
            if(hoursOfSleep > 8)
            {
                Console.WriteLine("You are well rested");
            }
            else
            {
                Console.WriteLine("You need more sleep");
            }

            

        }
    }
}
