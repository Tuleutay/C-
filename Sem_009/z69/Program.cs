/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8 */

Console.WriteLine("Введите A");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
Console.WriteLine("Введите B");
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);
if (!isParsedA || !isParsedB)
{
    Console.WriteLine("Ошибка!");
    return;
}
int exp = Exponentiate(a,b);

Console.WriteLine(exp);

int Exponentiate(int a, int b)
{
    int exp=1;
    if (b!=0)
    {
        exp *= a;
        b--;
        exp *= Exponentiate(a,b);
    }             
    return exp;                                                                                                
}
                                 



