// Программа выводит таблицу чисел в необходимой степени для диапазона [1,N]
void Step(int num, int step)
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
            if (step < 0 && n == 0)
            {
                Console.Write("Err ");
                n -= 1;
            }
        }
}

Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень ");
int b = int.Parse(Console.ReadLine()!);
Step(a, b);
