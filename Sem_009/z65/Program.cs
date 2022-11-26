/* Задача 65: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8" */

Console.WriteLine("Введите N");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите M");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
FillNumbers(m,n);
void FillNumbers(int m, int n)
{
    Console.Write($"{n} ");   
    if (n!=m)
    {
        n++;
        FillNumbers(m,n);
    }
    
}
