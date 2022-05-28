// See https://aka.ms/new-console-template for more information
int NatDegree(int a, int b)
{
    int result = a;
    for (int i=0; i <= (b-2); i++)
    {
            result = result * a; 
    }
    return result;
}
Console.WriteLine("Введите число A:");
int A = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int B = Int32.Parse(Console.ReadLine());
int res = NatDegree(A,B);
Console.WriteLine(res);