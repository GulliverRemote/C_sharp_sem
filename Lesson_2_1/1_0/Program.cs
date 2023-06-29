/*

*/



void Chetv(int x, int y)
{
    Console.WriteLine($"Координаты точки ({x}, {y})");
    if (x == 0 || y == 0)
        Console.WriteLine("Точка на оси");
    else if (x > 0 && y > 0)
        Console.WriteLine("Точка находится в 1 четверти");
    else if (x < 0 && y > 0)
        Console.WriteLine("Точка находится в 2 четверти");
    else if (x < 0 && y < 0)
        Console.WriteLine("Точка находится в 3 четверти");
    else if (x > 0 && y < 0)
        Console.WriteLine("Точка находится в 4 четверти");
}

Console.WriteLine("Введите координаты точки");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
Chetv(num1, num2);
