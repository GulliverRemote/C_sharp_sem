// 1. Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.

void IntegerNumbers(int a)
{
    if (a == 0) return;
    IntegerNumbers(a - 1);
    Console.Write(a + " ");
    
}
Console.WriteLine("Ведите число: ");
int num = int.Parse(Console.ReadLine()!);

IntegerNumbers(num);
