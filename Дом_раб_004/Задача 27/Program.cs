// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
//Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
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
Console.Write(GetSumNumbers(number));

int GetSumNumbers(int number)
{
    int sumNum = 0;
    while(number > 0)
    {
        sumNum = sumNum + number%10;
        number /= 10;
    }

    return sumNum;
}