// Задача 21 - Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние м/у ними в 2D пространстве.

double Distance(int x1, int y1, int x2, int y2)
{
    double dis = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    return dis;
}
Console.WriteLine("Введите координаты точ. A");
bool isParsedXA = int.TryParse(Console.ReadLine(), out int xA);
bool isParsedYA = int.TryParse(Console.ReadLine(), out int yA);
Console.WriteLine("Введите координаты точ. B");
bool isParsedYB = int.TryParse(Console.ReadLine(), out int yB);
bool isParsedXB = int.TryParse(Console.ReadLine(), out int xB);
if (!isParsedXA || !isParsedYA || !isParsedXB || !isParsedYB)
{
    Console.WriteLine("Ошибка!!! Не правильно введены координаты");
    return;
}

double distanceS = Distance(xA, yA, xB, yB);
Console.WriteLine($"Расстояние м/у точками {distanceS}");