// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.


// Получение нового массива произведением пар чисел начального массива
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

void Triangle(int[] array)
{
  {
    if (array[0]<array[1]+array[2] && array[1]<array[0]+array[2] && array[2]<array[1]+array[0])
    Console.WriteLine("Это треугольник");
    else
    Console.WriteLine("Это не треугольник");
  }
}

Console.Write("Введите число элементов массива равная 3 ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение элемента массива : ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива : ");
int stop = int.Parse(Console.ReadLine()!);


int[] arr = FillMas(num, start, stop);
Console.WriteLine("\nМассив:");
PrintMas(arr);
Triangle(arr);

