// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[,] FillArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matr;
}

int[] FrequencyDictionary(int[,] array,int max)
{
    int[] countMas = new int[max+1];
    foreach (var item in array)
    {
        countMas[item] += 1;
    }
    return countMas;
}
void PrintMas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($"{i}-> {mas[i]} ");
    }
}

Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение элемента массива : ");
int minimal = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива : ");
int maximal = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];
FillArray(matrix, minimal, maximal);
PrintArray(matrix);

int[] newMas = FrequencyDictionary(matrix, maximal);
PrintMas(newMas);
