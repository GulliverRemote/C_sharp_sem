// Копия двумерного массива с помощью поэлементного копирования

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr, int min, int max)
{
    Console.WriteLine("\nМассив:");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(min, max+1);
        }
    }
}

int[,] MultPar(int[,] array)
{
    int[,] mas = new int[array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
        mas[i,j] = array[array.GetLength(0)-i-1,array.GetLength(1)-j-1];
        }
    }
    return mas;
}


int[,] matrix = new int[3, 4];
Console.Write("Введите минимальное значение элемента массива : ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива : ");
int stop = int.Parse(Console.ReadLine()!);
FillArray(matrix, start, stop);
PrintArray(matrix);
int[,] newmatr = MultPar(matrix);
Console.WriteLine("Новый массив: ");
PrintArray(newmatr);