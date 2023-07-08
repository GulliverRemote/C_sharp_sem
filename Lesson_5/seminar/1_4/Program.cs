// Получение нового массива произведением пар чисел начального массива
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
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] MultPar(int[] array1)
{
    if (array1.Length % 2 == 0)
    {
        int[] mas = new int[array1.Length / 2];
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = array1[i] * array1[array1.Length - i - 1];
        }
        return mas;
    }
    else
    {
        int[] mas = new int[array1.Length / 2 + 1];
        for (int i = 0; i < mas.Length - 1; i++)
        {
            mas[i] = array1[i] * array1[array1.Length - i - 1];
            mas[i + 1] = array1[i + 1];
        }
        return mas;
    }
}

Console.Write("Введите число элементов массива : ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение элемента массива : ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива : ");
int stop = int.Parse(Console.ReadLine()!);
int[] arr = FillMas(num, start, stop);
Console.WriteLine("\nМассив:");
PrintMas(arr);
int[] FinalMas = MultPar(arr);
Console.WriteLine("\nПолученный массив:");
PrintMas(FinalMas);
