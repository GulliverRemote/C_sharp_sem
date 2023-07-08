// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Step(int num, int step)
{
    if (step < 0 && num == 0)
        Console.Write("Err ");
    else
        Console.Write($"{Math.Pow(num, step)} ");
}

Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень ");
int b = int.Parse(Console.ReadLine()!);
Step(a, b);
