// See https://aka.ms/new-console-template for more information
int[] array = new int[8];
string resalt = string.Empty;
for (int i=0; i <= array.Length - 1; i++)
{
    
    array[i] = new Random().Next(1,21);
    resalt = array[i] + ", " + resalt;
   
    
}
string resalt2 = resalt.Substring(0, resalt.Length - 2); 
Console.WriteLine($"Случайный массив из 8ми элементров: [{resalt2}]");

