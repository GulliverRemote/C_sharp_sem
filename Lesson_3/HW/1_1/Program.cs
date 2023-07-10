// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumDigit(int num)
{
    int res = 0;
    for (int n = Math.Abs(num); n > 0; n /= 10)
    {
        res += n % 10;
    }
    return res;
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {number} равна {SumDigit(number)}");
