// See https://aka.ms/new-console-template for more information
int NatDegree(string a)
{
    //Console.WriteLine(a[2]);
    int b = Convert.ToInt32(a);
    int result = 0;
    int m=0;
    for (int i=0; i < a.Length; i++)
    {
        m = b % 10;
        b = b / 10;
        result +=m;
    }
    return result;
}
Console.WriteLine("Введите число: ");
string A = Console.ReadLine();

int res = NatDegree(A);
Console.WriteLine(res);
