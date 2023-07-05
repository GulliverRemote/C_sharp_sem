//Цикл for

string Method4(int count, string text) //поменять имя переменной f2
{
    int i = 0;
    string result = string.Empty;

    // while (i < count)
    // {
    //     result = result + text;
    //     i++;
    // }

    for (i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);
