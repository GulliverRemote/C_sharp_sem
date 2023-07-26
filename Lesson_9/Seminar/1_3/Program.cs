// 4. Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

double SumDigits(double num, double step)
{
    if (step == 1)
        return num;
    if (step > 0)
        return SumDigits(num, step - 1) * num;
    else if (step < 0)
        return 1 / (SumDigits(num, Math.Abs(step) - 1) * num);
    else
        return 1;
}

Console.WriteLine("Введите число: ");
double n = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень: ");
double m = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Результат = {SumDigits(n, m)}.");
