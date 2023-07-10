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

void SumNegatPosit(int[] array)
{
    int pos = 0,
        neg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            neg += array[i];
        else
            pos += array[i];
    }
    Console.WriteLine("Сумма положительных элементов: " + pos);
    Console.WriteLine("Сумма отрицательных элементов: " + neg);
}

Console.Write("Введите число элементов массива : ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение элемента массива : ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива : ");
int stop = int.Parse(Console.ReadLine()!);
int[] arr = FillMas(num, start, stop);
PrintMas(arr);
SumNegatPosit(arr);
