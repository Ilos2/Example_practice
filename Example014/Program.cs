// See https://aka.ms/new-console-template for more information
int[] array = new int[4];
string resalt = string.Empty;
int chet = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    
    array[i] = new Random().Next(100,999);
    if(array[i] % 2==0)
    {
        chet++;
    }
    resalt = array[i] + ", " + resalt;
   
    
}
string resalt2 = resalt.Substring(0, resalt.Length - 2); 
Console.WriteLine($"В массиве [{resalt2}]: чётных чисел {chet}");