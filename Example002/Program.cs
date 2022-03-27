using System;

namespace Example002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int numberA = Int32.Parse(Console.ReadLine());
            int Max = numberA;
            Console.WriteLine("Введите второе число:");
            int numberB = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите второе число:");
            int numberC = Int32.Parse(Console.ReadLine());
            
            //int result1=0;

            if (Max < numberB)
            {
                Max = numberB;
            }  
                      
            if (Max < numberC)
            {
                Max = numberC;
            }
            
            
            Console.Write("Болешее число = "); 
            Console.WriteLine(Max);
            
        }
    }
}
