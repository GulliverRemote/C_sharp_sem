/*
Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Последняя цифра в этом числе - " + a % 10);
*/



int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}

int a = new Random().Next(100,1000);
int result = TakeNum(a);
Console.WriteLine(result); 