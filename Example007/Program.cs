using System;

namespace Example007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day: ");
            int day = Int32.Parse(Console.ReadLine());

            if (day<=5)
            {
            Console.WriteLine("working day");
            }
            else if (day>=6 & day<=7)
            {
                Console.WriteLine("day off");
            }
            else if (day >= 8)
            {
                Console.WriteLine("what world do you live in?");
            }
        }
    }
}