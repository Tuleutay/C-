// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
int length = GetLengthNumber(number);
if(!isParsed || length !=5)
{
    Console.WriteLine("Не правильно введены данные");
    return;
}
int GetLengthNumber(int number)
{
    int count = 0;
    while(number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}
void CheckPolindromNumber(int number) 
{
    int[] array = new int[length];
    for (int k = length -1 ; k >= 0; k--)
        {
            array[k] = number % 10;
            number /= 10;
        }
    int j = length - 1; 
    int i = 0;
    while (i <= j)
    {
        if (array[i] != array[j])
        {
            Console.WriteLine("Число не является полиндромом");
            return;
        }
        i++;
        j--; 
    }
        Console.WriteLine("Число полиндромом");
        return;
}
CheckPolindromNumber(number);