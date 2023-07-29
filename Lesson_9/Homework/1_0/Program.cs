// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

void IntegerNumbers(int a, int b) 
{
    if (a > b) return;
    if (a%2==0)
    {
    Console.Write(a + " ");
    IntegerNumbers(a + 2, b);}
    else
    IntegerNumbers(a + 1, b);
}
Console.WriteLine("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int m = int.Parse(Console.ReadLine()!);

IntegerNumbers(n, m);