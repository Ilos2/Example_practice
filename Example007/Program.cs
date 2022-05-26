// See https://aka.ms/new-console-template for more information

//int week=0;

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
}
