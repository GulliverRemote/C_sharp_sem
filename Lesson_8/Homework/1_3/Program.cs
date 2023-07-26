// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.


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

int[] Minimal(int[,] array)
{
    int min = array[0, 0];
    int[] indexMin = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                indexMin[0] = i;
                indexMin[1] = j;
            }
        }
    }
    Console.WriteLine(min);
    return indexMin;
}

int[,] ChangedMas(int[,] array, int[] imin)
{
    int[,] changeMas = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (i >= imin[0] && j >= imin[1])
                changeMas[i, j] = array[i + 1, j + 1];
            else if (i >= imin[0])
                changeMas[i, j] = array[i + 1, j];
            else if (j >= imin[1])
                changeMas[i, j] = array[i, j + 1];
            else
                changeMas[i, j] = array[i, j];
        }
    }
    return changeMas;
}

Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);

int[] minElement = Minimal(matrix);
Console.WriteLine($"{minElement[0]}, {minElement[1]}");
int[,] changeMatrix = ChangedMas(matrix, minElement);
PrintArray(changeMatrix);
