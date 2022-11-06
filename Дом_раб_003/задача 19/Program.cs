// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
  Console.WriteLine("Введите число");
  int number = Convert.ToInt32(Console.ReadLine());
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
    int length = GetLengthNumber(number);
    int mj = length % 2;
    if (mj == 0) 
    { 
      Console.WriteLine("Ошибка! Ввели четное число");
    }
    else 
    {
        int[] array = new int[length];
        for (int j = length -1; j >= 0; j--)
        {
            array[j] = number % 10;
            number /= 10;
        }
        int i = 0;
        while (i < mj / 2)
        {
            if (array[i] == array[mj - i])
            {
                 i++;
            }
            else Console.WriteLine("Число не является полиндромом");
        }
        Console.WriteLine("Число полиндромом");
    }
}
CheckPolindromNumber(number);