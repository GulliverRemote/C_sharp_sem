Console.WriteLine("Введите два числа для сравнения ");
int num_A = int.Parse(Console.ReadLine()!);
int num_B = int.Parse(Console.ReadLine()!);

if (num_A/num_B == num_B)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}