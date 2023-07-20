// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] PrintArray(int[,] matr)
{
    Console.WriteLine("\nМассив:");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 3} ");
        }
        Console.WriteLine();
    }
    return matr;
}

int[,] FillArray(int[,] matr)
{
    Console.Write("Введите минимальное значение элемента массива : ");
    int min = int.Parse(Console.ReadLine()!);
    Console.Write("Введите максимальное значение элемента массива : ");
    int max = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matr;
}

void AverageOfColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Среднее арифметическое в {j + 1} столбце равно {sum}");
    }
}

Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, n];

AverageOfColumn(PrintArray(FillArray(matrix)));
//FillArray(PrintArray(AverageOfColumn(matrix)));