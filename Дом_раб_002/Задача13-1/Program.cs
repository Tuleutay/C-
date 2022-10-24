Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int threeDigit = GetThreeDigit(number);
Console.WriteLine(threeDigit);

//bool CheckLenghtNumber(int number)
//{
//    return number > 99 && number < 1000;
//}
int GetLenghtNumber(int number)
{
    int count = 0;
    while(number > 0)
    {
        number/=10;
        count++;
    }
    return count;
}

int GetThreeDigit(int number)
{
    int lenth = GetLenghtNumber(number);
    int[] array = new int[lenth];
if (lenth < 3) Console.WriteLine("третьей цифры нет");
    for (int i = lenth -1; i >= 0; i--)
    {
        array[i] = number % 10;
        number /= 10;
        
    }
    return array[2];
}




