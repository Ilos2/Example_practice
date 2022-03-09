using System;

namespace Example010
{
    class Program
    {
        static void Main()
        {
            int cubnum;
            Console.WriteLine("Таблица кубов!\n\nВведите число");
            cubnum = Int32.Parse(Console.ReadLine());
            for (int i=1; i<=cubnum;i++)
            Console.WriteLine(i*i*i);
        }  
  
    }
}
