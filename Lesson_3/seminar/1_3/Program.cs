int[] FillMas(int n)
{
    int[] Mas = new int[n];
    for (int i = 0; i < n; i++)
    {
        Mas[i] = new Random().Next(0, 2);
    }
    return Mas;
}

void PrintMas(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
int[] arr = FillMas(num);
PrintMas(arr);
