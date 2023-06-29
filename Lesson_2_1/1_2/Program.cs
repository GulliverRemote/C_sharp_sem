double Rasst(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
}

Console.WriteLine("Введите координаты двух точек");
int xa = int.Parse(Console.ReadLine()!),
    ya = int.Parse(Console.ReadLine()!),
    xb = int.Parse(Console.ReadLine()!),
    yb = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Первая точка ({xa},{ya}), Вторая точка ({xb},{yb})");
double result = Rasst(xa, ya, xb, yb);
Console.WriteLine("Расстояние " + result);
