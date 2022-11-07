//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
//Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
//
//3, 5 -> 243 (3⁵)
//
//2, 4 -> 16

Console.WriteLine("Введите числа A и B");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);
if(!isParsedA || !isParsedB)
{
    Console.WriteLine("Не правильно введены числа");
    return;
}
int Exponentiation(int a, int b)
{
    int s = 1;
    for (int i = 1; i <= b; i++)
    {
        s*= a;
    }
    return s;
}
Console.Write(Exponentiation(a, b));