//Задача 2 из домашки семинара
/*
Бутофорский метод
void Del2(int num)
{
    Console.WriteLine(num);
    Console.WriteLine(num / 100 + "" + num % 10);
}
*/

int Del2(int num)
{
    Console.WriteLine(num);
    return (num / 100) * 10 + (num % 10);
}

int a = new Random().Next(100, 1000),
    res = Del2(a);
Console.WriteLine(res);
