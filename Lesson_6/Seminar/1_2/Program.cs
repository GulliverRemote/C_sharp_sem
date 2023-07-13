// 2. Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.


string Binary (int num)
{
    string number = string.Empty;

    for (; num !=0; num/=2)
    {
        number = num%2 + number;
    }
    return number;
}


Console.WriteLine(Binary (12));