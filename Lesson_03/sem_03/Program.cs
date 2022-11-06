// Напишите программу, которая принимает на вход координаты точки (Х, У), причем Х и У
//не равны 0 и выдает номер четвертой плоскости, в которой находится эиа точка.
//bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

if(isParsedX || isParsedY)
{
    Console.WriteLine("Ошибка! Не правильно введены координаты");

    return;
}
int numberOfQuarter = DetermineNumberOfQuarter(x, y);
//if(numberOfQuarter == -1)
//{
//    Console.WriteLine("Ошибка! Не правильно ввели данные");
//}//
//else
//{
//    Console.WriteLine(numberOfQuarter);
//}
int DetermineNumberOfQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    if (x > 0 && y < 0)
    {
        return 4;
    }
    return -1;
}