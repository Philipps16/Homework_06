Console.Clear();
Console.WriteLine("Введите число b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = - (b1 - b2)/(k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Координаты точки пересечения равны [{Math.Round(x, 1)}, {Math.Round(y, 1)}]");