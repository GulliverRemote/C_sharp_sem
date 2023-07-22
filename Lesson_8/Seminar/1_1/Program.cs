// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

void Transp(int[,] array)
{
    if (array.GetLength(0)!=array.GetLength(1))
    {
     Console.WriteLine("Транспонирование не возможно");
     return;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            (array[i, j], array[j, i]) = 
            (array[j, i],array[i, j]); //метод кортежа
        }
    }
}

Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Transp(matrix);
PrintArray(matrix);
