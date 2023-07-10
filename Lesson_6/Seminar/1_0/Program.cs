// 1. Напишите программу, которая перевернёт одномерный массив
//    (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] FillMas(int n, int min, int max)
{
    int[] Mas = new int[n];
    for (int i = 0; i < n; i++)
    {
        Mas[i] = new Random().Next(min, max + 1);
    }
    return Mas;
}

void PrintMas(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void MultPar(int[] array)
{
    // int[] mas;
    // if (array.Length % 2 == 0)
    //     mas = new int[array.Length / 2];
    // else
    //     mas = new int[array.Length / 2 + 1];
    // for (int i = 0; i < mas.Length; i++)
    // {
    //     if (i != array.Length - i - 1)
    //         mas[i] = array[array.Length - i - 1];
    //     else
    //         mas[i] = array[i];
    // }

    int size = array.Length;

    for (int i = 0; i < size / 2; i++)
    {
        (array[i], array[size - i - 1]) = (array[size - i - 1], array[i]);
        // int a=array[i];
        // array[i] = array[size - i - 1];
        // array[size - i - 1] = a;
    }
}

Console.Write("Введите число элементов массива : ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение элемента массива : ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива : ");
int stop = int.Parse(Console.ReadLine()!);
int[] arr = FillMas(num, start, stop);
Console.WriteLine("\nМассив:");
PrintMas(arr);
MultPar(arr);
Console.WriteLine("\nПолученный массив:");
PrintMas(arr);
