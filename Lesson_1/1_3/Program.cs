int a = int.Parse(Console.ReadLine()!); //-6
int count = -a;// count 6
Console.WriteLine(count);
while (count != a)
{
    if (a > 0)
        count++;
    else
        count--;
    Console.WriteLine(count);
}