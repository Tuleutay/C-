// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите три числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckingTriangle(a, b, c));

bool CheckingTriangle(int a, int b, int c)
{
    if (a <= 0 & b <= 0 & c <= 0)
    {
        return false;
    }
    return a < b + c & b < a + c & c < a + b;
}