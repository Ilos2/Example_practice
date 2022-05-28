// See https://aka.ms/new-console-template for more information
int SumNum(string a)
{
    //Console.WriteLine(a[2]);
    int result=0;
    //int[] b = new int [a.Length];
    for (int i=0; i < a.Length ; i++)
    {
        
        if (a[i]>0)
        {
            result += Convert.ToInt32(a[i]); 
            Console.WriteLine(a[i]);
            //Console.WriteLine(b[i]);
        }
    }
    
    
    return result;
    
}
Console.WriteLine("Введите число: ");
string A = Console.ReadLine();

int res = SumNum(A);
Console.WriteLine(res);
