int Sec(int num)
{
    Console.WriteLine(num);
    if (num > 0)
        return (num / 10) % 10;
    return Math.Abs(num / 10) % 10;
}

Console.WriteLine("Введите трехзначное число");
int three = int.Parse(Console.ReadLine()!),
    Out = Sec(three);
Console.WriteLine($"Вторая цифра числа равна {Out}");
