// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int CountMoreZero()
{
    int count = 0;
    double num = 0;
    Console.WriteLine("Введите числа, стоп число -1 : ");
    while (num != -1)
    {
        num = double.Parse(Console.ReadLine()!);
        if (num > 0)
            count++;
    }
    return count;
}

Console.WriteLine($"Чисел больше 0 = {CountMoreZero()}");