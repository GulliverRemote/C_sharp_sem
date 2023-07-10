// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] FillMas(int n, double min, double max)
{
    double[] Mas = new double[n];
    for (int i = 0; i < n; i++)
    {
        Mas[i] = new Random().NextDouble() * (max - min) + min; // min = 0; max = 10;  0*(10-0)+0=0;   1*(10-0)+1=10;   ??????????????????
        Mas[i] = Math.Round(Mas[i], 3);
    }
    return Mas;
}

void PrintMas(double[] array)
{
    Console.WriteLine("\nМассив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double DiffMinMax(double[] array)
{
    double diff = 0,
        min = array[0],
        max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
        diff = Math.Round(max - min, 3);
    }
    return diff;
}

Console.Write("Введите число элементов массива : ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение элемента массива : ");
double start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива : ");
double stop = int.Parse(Console.ReadLine()!);
double[] arr = FillMas(num, start, stop);
PrintMas(arr);
double result = DiffMinMax(arr);
Console.WriteLine($"\nРазница между максимальным и минимальным элементом равна {result}");
