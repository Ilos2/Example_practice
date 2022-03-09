using System;
    class Palindr
     {
    static void Main()
        {
        string s;
            Console.WriteLine("Анализ палиндромов\n\nВведите строку:");
          s = Console.ReadLine();
           if (Palindrom(s))
       Console.WriteLine("Эта строка - палиндром");
       else Console.WriteLine("Эта строка - не палиндром");

        }
        
        public static bool Palindrom (string s)
        {
                for (int i = 0, j = s.Length - 1; i < j; i++, j--)
                    if (s[i] != s[j])
                        return false;
                    return true;                    
        }
     
    
    }