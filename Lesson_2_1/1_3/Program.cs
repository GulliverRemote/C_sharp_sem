void Kvadr(int num, int step)
{
    int n = 1;
    if (num > 0)
    {
        while (n < num + 1)
        {
            Console.Write($"{Math.Pow(n, step)} ");
            n += 1;
        }
    }
    else
        while (n > num - 1)
        {
            Console.Write($"{Math.Pow(n, step)} ");
            n -= 1;
            if (n == 0)
            {
                Console.Write("no ");
                n -= 1;
            }
        }
}

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
Kvadr(a, a);
