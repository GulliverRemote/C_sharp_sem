Console.WriteLine("Введите число");

int a = int.Parse(Console.ReadLine()!); //-6
int count = 1;// count 6
while (count != a)
{
    if (a > 0)
        count++;
    else
        count--;
    if (count % 2 == 0)
        Console.WriteLine(count);
}