void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 3} ");
        }
        Console.WriteLine();
    }
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

int[,] MatrixMultiplication(int[,] arrayFirst, int[,] arraySecond)
{
    int[,] arrayMult = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];
    for (int k = 0; k < arrayMult.GetLength(0); k++)
    {
        for (int i = 0; i < arrayFirst.GetLength(0); i++)
        {
            for (int j = 0; j < arrayFirst.GetLength(1); j++)
            {
                arrayMult[k, i] += arrayFirst[k, j] * arraySecond[j, i];
            }
        }
    }
    return arrayMult;
}

Console.WriteLine("Введите количество строк 1 матрицы ");
int mFirst = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов 1 матрицы ");
int nFirst = int.Parse(Console.ReadLine()!);
int[,] firstMatrix = new int[mFirst, nFirst];
FillArray(firstMatrix);
Console.WriteLine("\nПервый массив:");
PrintArray(firstMatrix);

Console.WriteLine("Введите количество строк 2 матрицы ");
int mSecond = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов 2 матрицы ");
int nSecond = int.Parse(Console.ReadLine()!);
int[,] secondMatrix = new int[mSecond, nSecond];
FillArray(secondMatrix);
Console.WriteLine("\nВторой массив:");
PrintArray(secondMatrix);

Console.WriteLine();
int[,] resultMatrix = new int[mFirst, mSecond];
if (firstMatrix.GetLength(0) != secondMatrix.GetLength(1))
    Console.WriteLine("Маассивы нельзя перемножить");
else
{
    resultMatrix = MatrixMultiplication(firstMatrix, secondMatrix);
    Console.WriteLine("\nПолученный массив:");
PrintArray(resultMatrix);
}
