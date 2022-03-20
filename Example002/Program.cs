Console.WriteLine("Введите первое число:");
int numberA = Int32.Parse(Console.ReadLine());
int Min = numberA;
Console.WriteLine("Введите второе число:");
int numberB = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int numberC = Int32.Parse(Console.ReadLine());
int Max = numberA;

if (Max <= numberB)
{
    Max = numberB;
}
else 
if (Max < numberC)
{
    Max = numberC;
}
           
Console.Write("Максимальное число = "); 
 Console.WriteLine(Max);
            

            
