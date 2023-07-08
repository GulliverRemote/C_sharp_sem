int[] FillMas(int n, int min, int max)
{
    int[] Mas = new int[n];
    for (int i = 0; i < n; i++)
    {
        Mas[i] = new Random().Next(min, max + 1);
    }
    return Mas;
}

void PrintMas(int[] array)
{
    Console.WriteLine("\nМассив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void CountFromDiap(int[] array)
{
    int count = 0;
    Console.WriteLine("Введите min искомого диапазона числа");
    int min = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите max искомого диапазона числа");
    int max = int.Parse(Console.ReadLine()!);
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max)
            count++;
    }
    Console.WriteLine($"Количество элементов в диапазоне [{min},{max}] = {count} ");
}

Console.Write("Введите число элементов массива : ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение элемента массива : ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива : ");
int stop = int.Parse(Console.ReadLine()!);
int[] arr = FillMas(num, start, stop);
PrintMas(arr);
CountFromDiap(arr);
