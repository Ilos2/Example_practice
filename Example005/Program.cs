using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            //string num = Console.ReadLine();
      
            //var center = (num.Length%10) +1;

            string s;
            string result;
            s = Console.ReadLine();
            if ((s.Length) % 2 == 0)
            {
                result = s.Substring((((s.Length) / 2)-1), 2);
            }
            else
            {
                result = s.Substring(((s.Length) / 2), 1);
            }
 
            Console.WriteLine(result);
            
                           
        }
    }
}
