// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние м/у ними в 3Д пространстве
double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dis = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return dis;
}
Console.WriteLine("Введите координаты точ. A");
bool isParsedXA = int.TryParse(Console.ReadLine(), out int xA);
bool isParsedYA = int.TryParse(Console.ReadLine(), out int yA);
bool isParsedZA = int.TryParse(Console.ReadLine(), out int zA);
Console.WriteLine("Введите координаты точ. B");
bool isParsedYB = int.TryParse(Console.ReadLine(), out int yB);
bool isParsedXB = int.TryParse(Console.ReadLine(), out int xB);
bool isParsedZB = int.TryParse(Console.ReadLine(), out int zB);
if (!isParsedXA || !isParsedYA || !isParsedZA || !isParsedXB || !isParsedYB || !isParsedZB)
{
    Console.WriteLine("Ошибка!!! Не правильно введены координаты");
    return;
}

double distanceS = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние м/у точками {distanceS}");