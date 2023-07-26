// 2. Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.

void IntegerNumbers(int a, int b) 
{
    if (a == b+1) return;
    Console.Write(a + " ");
    IntegerNumbers(a + 1, b);
    
}
Console.WriteLine("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int m = int.Parse(Console.ReadLine()!);

IntegerNumbers(n, m);
