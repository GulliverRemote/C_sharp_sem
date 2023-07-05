/*
int NumDigits(int num)
{
    int count = 0;
    for (int i = 1; i <= Math.Abs(num); i *= 10)
        count++;
    // while (num > 0)
    // {
    //     num = num / 10;
    //     count++;
    // }
    return count;
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int res = NumDigits(number);
Console.WriteLine("Количество цифр в числе = " + res);
*/

 Console.WriteLine("Введите число");
 string number = Console.ReadLine();
 Console.WriteLine("Количество цифр = " + number.Length);
