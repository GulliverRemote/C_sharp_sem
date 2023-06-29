void DayOff(int day)
{
    /*if (day == 1)
        Console.WriteLine("Понедельник - день тяжелый, работаем");
    else if (day == 2)
        Console.WriteLine("Вторник - отдых от понедельника, работаем");
    else if (day == 3)
        Console.WriteLine("Среда - половина рабочей недели");
    else if (day == 4)
        Console.WriteLine("Четверг - подготовка к пятнице, работаем");
    else if (day == 5)
        Console.WriteLine("Пятница - немного и в отрыв, а пока дорабатываем");
    else if (day == 6)
        Console.WriteLine("Суббота - продолжаем пятничную радость, ВЫХОДНОЙ!!!");
    else if (day == 7)
        Console.WriteLine(
            "Воскресенье - отходим от радости, готовимся к понедельнику =( ВЫХОДНОЙ "
        );
    else
        Console.WriteLine("Нет такого дня?");
        */

    if (day > 0 && day < 6)
        Console.WriteLine("Будний день");
    else if (day > 5 && day < 8)
        Console.WriteLine("ВЫХОДНОЙ!!!");
    else
        Console.WriteLine("Кто здесь?");
}

Console.WriteLine("Введите день недели цифрой");
int a = int.Parse(Console.ReadLine()!);
DayOff(a);
