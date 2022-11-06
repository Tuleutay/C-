//Задача 26: Напишите программу, которая принимает 
//на вход число и выдаёт количество чисел.
Console.WriteLine("Введите число");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if(!isParsed)
{
    Console.WriteLine("Не правильно введены данные");
    return;
}
if(number < 1)
{
    Console.WriteLine("0");
    return;
}
int countNum = GetCountNumbers(number);
Console.WriteLine(countNum);
int GetCountNumbers(int number)
{
    int countNum;
    for ( countNum = 0; number > 0; countNum++)
    {
        number /= 10;
    }

    return countNum;
}