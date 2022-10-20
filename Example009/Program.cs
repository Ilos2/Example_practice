Console.Clear();

Console.WriteLine("Введите координату x для первой точки:");
int xa = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату y для первой точки:");
int ya = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату z для первой точки:");
int za = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату x для второй точки:");
int xb = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату y для второй точки:");
int yb = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату z для второй точки:");
int zb = Convert.ToInt32(Console.ReadLine());

double l = Math.Sqrt((Math.Pow((xb-xa), 2))+(Math.Pow((yb-ya), 2))+(Math.Pow((zb-za), 2)));
Console.WriteLine($"Рассещяние между точками {Math.Round(l, 2)}");