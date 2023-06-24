Console.WriteLine("Введите 2 числа");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if (a>b)
Console.WriteLine($"MAX = {a} ; MIN = {b}");
else if (b>a)
Console.WriteLine($"MAX = {b} ; MIN = {a}");
else
Console.WriteLine($"Первое число a = {a} равно второму числу b = {b}");