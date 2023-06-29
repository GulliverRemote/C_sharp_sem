int Third(int num)
{
    Console.WriteLine(num);
    num = Math.Abs(num);
    if (num < 100)
        return -1;
    while ((num) > 999)
        num = num / 10;
    return num % 10;
}

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!),
    res = Third(a);
if (res == -1)
    Console.WriteLine("В данном числе нет третей цифры");
else
    Console.WriteLine($"Третья цифра - {res}");
