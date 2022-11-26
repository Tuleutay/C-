/* Задача 68: Напишите метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите M");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите N");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}
int result = GetResultFunktionAkkerman(m,n);
Console.Write(result);

int GetResultFunktionAkkerman (int m, int n)
{   
    int result = 0;
    if(m==0)
    {
        result = n + 1;
    }
    else if(m>0 && n==0)
    {
        result = GetResultFunktionAkkerman(m-1,1);
    }
    else result = GetResultFunktionAkkerman(m-1,GetResultFunktionAkkerman(m,n-1));
    return result;
}
