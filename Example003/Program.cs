using System;

namespace Example003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Int32.Parse(Console.ReadLine());
                        
            if (number % 2==0)
            {   
                Console.WriteLine("да");
            
            }
            else
            {
                Console.WriteLine("нет");
            }
                
            //}
            //return;
            
        }
    }
}