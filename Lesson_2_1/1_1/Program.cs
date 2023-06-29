void diap(int num)
{
    Console.WriteLine($"Введена {num} четверть");
    if (num > 4 && num < 1)
        Console.WriteLine("нет такой четверти");
    else
    {
        switch (num)
        {
            case 1:
                Console.WriteLine("x > 0 ,y > 0");
                break;
            case 2:
                Console.WriteLine("x < 0 ,y > 0");
                break;
            case 3:
                Console.WriteLine("x < 0 ,y < 0");
                break;
            case 4:
                Console.WriteLine("x > 0 ,y < 0");
                break;
        }
    }
}

Console.WriteLine("Введите номер четверти");
int a = int.Parse(Console.ReadLine()!);
diap(a);
