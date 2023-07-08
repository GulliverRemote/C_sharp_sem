// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillMas(int n) //заполнение массива с клавиатуры
{
    int[] Mas = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"\nВведите элемент массива [{i}] : ");
        Mas[i] = int.Parse(Console.ReadLine()!);
    }
    return Mas;
}

void PrintMas(int[] array)
{
    Console.WriteLine("\nМассив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число элементов массива");
int num = int.Parse(Console.ReadLine()!);
int[] Arr = FillMas(num);
PrintMas(Arr);
