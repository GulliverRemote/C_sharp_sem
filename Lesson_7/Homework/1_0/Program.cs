// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 5} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    Console.Write("Введите минимальный элемент :");
    int min = int.Parse(Console.ReadLine()!);
    Console.Write("Введите максимальный элемент :");
    int max = int.Parse(Console.ReadLine()!);
    Console.WriteLine("\nМассив:");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round ((new Random().NextDouble() * (max - min) + min),4);
            
        }
    }
}

Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);
double[,] matrix = new double[m, n];
FillArray(matrix);
PrintArray(matrix);
