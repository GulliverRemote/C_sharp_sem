// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int MinimalSumRow(int[,] array)
{
    int[] sum = new int[array.GetLength(1)];
    int minRow =0; 
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum[i] += array[i,j];
            }
    }
    for (int i = 0; i < sum.Length-1; i++)
    {
        if (sum[i] < sum[i+1]) minRow = i;
    }
    return minRow;
}

void PrintRow(int[,] array, int row)
{
    Console.WriteLine($"Строка с наименьшей суммой - {row+1}:");
    for (int j = 0; j < array.GetLength(1); j++)
    {
       Console.Write($"{array[row,j]} "); 
    }
}

Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
int minimalRow =  MinimalSumRow(matrix);
PrintRow(matrix,minimalRow);