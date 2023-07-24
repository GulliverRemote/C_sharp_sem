//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//   и возвращает значение этого элемента или же указание, что такого элемента нет.


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
            matr[i, j] = Math.Round((new Random().NextDouble() * (max - min) + min), 4);
        }
    }
}

void OutputElementArray(double[,] matr)
{
    Console.Write("\nВведите строку элемента: ");
    int row = int.Parse(Console.ReadLine()!) ;
    Console.Write("Введите столбец элемента: ");
    int column = int.Parse(Console.ReadLine()!);
    if (
        row > matr.GetLength(0)
        || row <= 0
        || column > matr.GetLength(1)
        || column <= 0
    )
    {
        Console.WriteLine($"\nЭлемента с позицией [{row},{column}] нет в массиве");
        return;
    }
    else
    {
        Console.WriteLine(
            $"\nЭлемент с индексами [{row},{column}] равен {matr[row-1, column-1]}"
        );
        return;
    }
}

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
double[,] matrix = new double[m, n];
FillArray(matrix);
PrintArray(matrix);
OutputElementArray(matrix);
