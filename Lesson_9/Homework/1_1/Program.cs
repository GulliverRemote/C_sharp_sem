// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

int SumDigits(int numFirst, int numSecond)
{
    if (numFirst == numSecond)
        return numFirst;
    return SumDigits(numFirst + 1, numSecond) + numFirst;
}

Console.WriteLine("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumDigits(n, m));
