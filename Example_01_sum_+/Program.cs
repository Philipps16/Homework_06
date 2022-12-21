Console.Clear();

Console.WriteLine("Введите числа: ");
int [] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    count++;
}
Console.WriteLine($"Количество введенных положительных чисел: {count}");