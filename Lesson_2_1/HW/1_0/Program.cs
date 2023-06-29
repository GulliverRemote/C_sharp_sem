// Полиндром ли?
void Polin(int num)
{
    if (num > 10000 && num < 100000)
    {
    if ((num/10000 == num%10) && ((num/1000)%10)==(num/10)%10)
    Console.WriteLine($"Число {num} полином");
    else
    Console.WriteLine($"Число {num} не является полиномом");
    }
    else
    Console.WriteLine("Некорректное число");
}

Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine()!);
Polin(a);