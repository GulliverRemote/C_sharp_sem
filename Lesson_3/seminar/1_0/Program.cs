void Sum1toN(int num)
{
    int sum = 0;
    for (int i = 1; i < num + 1; i++)
        sum += i;
    Console.WriteLine("Summ =" + sum);
}

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);
Sum1toN(n);
