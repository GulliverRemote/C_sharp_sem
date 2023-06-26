int Num(int num)
{
    Console.WriteLine(num);
    /*
    int c = num % 10,
        d = num / 10,
        res;
    if (c > d)
    {
        res = c;
    }
    else
    {
        res = d;
    }
    return res;*/

    if (num / 10 > num % 10)
        return num / 10;
    return num % 10;
}

int a = new Random().Next(10, 100);
int result = Num(a);
Console.WriteLine(result);
