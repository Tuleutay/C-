// задача 28 - напишите программу, которая принимает на вход число N 
//и выдает произведение чисел от 1 до N.
Console.WriteLine("Введите число");
bool isParsed = int.TryParse(Console.ReadLine(), out int n);
if(!isParsed)
{
    Console.WriteLine("Не правильно введены данные");
    return;
}
if(n < 1)
{
    Console.WriteLine("0");
    return;
}
int mul = GetMulNumbers(n);
Console.WriteLine(mul);
int GetMulNumbers(int number)
{
    int mul = 1;

    for (int i = 1; i <= number; i++)
    {
        mul*= i;
    }

    return mul;
}
