// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициенты k1 и b1");
int k1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коэффициенты k2 и b2");
int k2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны, пересечения нет");
}
else
{
    Console.WriteLine($"Координаты точки пересечения: {LineIntersectionPoint(k1, b1, k2, b2)}");
}

(int, int) LineIntersectionPoint(int k1, int b1, int k2, int b2)
{
    int x = (b2 - b1) / (k1 - k2);
    int y = k1 * x + b1;
    return (x, y);
}
