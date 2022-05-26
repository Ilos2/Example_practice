using System;

namespace Example006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            char[] arr;
            string n = Console.ReadLine();
            arr = n.ToCharArray();
             
            
            //Console.WriteLine(arr.Length);
            if (arr.Length > 2)
            {
            Console.WriteLine(arr[2]);
            }
            else 
            Console.WriteLine("Третьего числа нет.");
        }
    }
}


