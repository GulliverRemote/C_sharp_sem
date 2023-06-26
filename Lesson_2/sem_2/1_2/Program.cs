void Ost(int a, int b)
{
    if (a % b == 0)
        Console.WriteLine($"{a} и {b} кратны");
    else
    Console.WriteLine($"{a} и {b} не кратны, остаток {a % b}");
}

int first = int.Parse(Console.ReadLine()!),
    sec = int.Parse(Console.ReadLine()!);
Ost(first, sec);
