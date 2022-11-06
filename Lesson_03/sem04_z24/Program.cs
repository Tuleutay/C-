//Задача 24: Напишите программу, которая принимает 
//на вход число (А) и выдаёт сумму чисел от 1 до А.
bool isParsed = int.TryParse(Console.ReadLine(), out int a);
if(!isParsed)
{
    Console.WriteLine("Не правильно введены данные");
    return;
}
if(a < 1)
{
    Console.WriteLine("0");
    return;
}
int sum = GetSumNumbers(a);
Console.WriteLine(sum);
int GetSumNumbers(int number)
{
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        sum+= i;
    }

    return sum;
}