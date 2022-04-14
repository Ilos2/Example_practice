using System;

namespace Example004
{
    class Program
    {
        static void Main(string[] args)
        //int numbers(int num)
        {
            int num;
            Console.WriteLine("Введите число: ");
            num = Int32.Parse(Console.ReadLine());
            int N = 1; //произведение 
            int i = 1;  //счётчик

            while (N < num - 1)
            {
                N = i * 2;
                i++;
                Console.Write(N);
                Console.Write(", ");
                
            }
            
        }
    }
}



