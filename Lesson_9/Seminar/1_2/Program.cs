// 3. Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр. Использовать рекурсию.

int SumDigits(int num)
{
    if (num/10 == 0)
        return num;
    return SumDigits(num/10)+num%10;
}

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumDigits(n));
