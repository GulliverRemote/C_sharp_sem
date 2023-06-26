Console.WriteLine("Введите 3 числа");
int a = int.Parse(Console.ReadLine()!),
    b = int.Parse(Console.ReadLine()!),
    c = int.Parse(Console.ReadLine()!);

int max = a;

if (max < b)
    max = b;
if (max < c)
    max = c;
Console.WriteLine($"Из введенных чисел {a} , {b} , {c}");
Console.WriteLine($"MAX = {max}");