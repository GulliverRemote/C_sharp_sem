// ничего не принимает ничего не возвращает
void Method1()
{
    Console.WriteLine("Автор Шипулин Андрей");
}
Method1();

// что-то принимает ничего не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(count: 4, msg: "Текст я");


//Что-то возвращает ничего не принимает
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);



// Что-то принимает что-то возвращает
string Method4(int count, string text ) //поменять имя переменной f2
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);