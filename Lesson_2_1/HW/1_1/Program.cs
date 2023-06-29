// Расстояние между двумя точками в 3D

double Rasst(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
}

Console.WriteLine("Введите координаты двух точек");
int xa = int.Parse(Console.ReadLine()!),
    ya = int.Parse(Console.ReadLine()!),
    za = int.Parse(Console.ReadLine()!),
    xb = int.Parse(Console.ReadLine()!),
    yb = int.Parse(Console.ReadLine()!),
    zb = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Первая точка ({xa},{ya},{za}), Вторая точка ({xb},{yb},{zb})");
double result = Rasst(xa, ya, za, xb, yb, zb);
Console.WriteLine("Расстояние " + result);
