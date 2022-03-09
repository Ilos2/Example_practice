using System;

namespace Example001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int numberA = Int32.Parse(Console.ReadLine());
            int Min = numberA;
            Console.WriteLine("Введите второе число:");
            int numberB = Int32.Parse(Console.ReadLine());
            int Max = numberB;
            int result1=0;
            int result2=0;
            if (numberA > numberB)
            {
                result1 = numberA;
                result2 = numberB;
            }
            else 
            {
                result1 = numberB;
                result2 = numberA;
            }
            //Console.WriteLine(result);
            Console.Write("Болешее число = "); 
            Console.WriteLine(result1);
            Console.Write("Меньшее число = "); 
            Console.WriteLine(result2);
        }
    }
}
