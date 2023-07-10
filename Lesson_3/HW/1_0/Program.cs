// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Step(int num, int step)
{
    double res = 1;
    if (step < 0 && num == 0)
    {
        Console.Write("Err ");
        return;
    }
    else if (step >= 0)
    {
        for (int i = 1; i <= step; i++)
            res *= num;
    }
    else
    {
        for (int i = 1; i <= Math.Abs(step); i++)
            res *= num;
        res = 1 / res;
    }
    Console.Write($"Число {num} в степени {step} = {res} ");
}

Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень ");
int b = int.Parse(Console.ReadLine()!);
Step(a, b);
