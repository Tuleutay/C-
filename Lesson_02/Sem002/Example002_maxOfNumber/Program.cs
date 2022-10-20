int GetRandomNumber(int minValue, int maxValue)
{
    Random random = new Random();
    int randomNumber = random.Next(minValue, maxValue);
    return randomNumber;
}
// метод для задачи 11 - удаляет второе число в трёхзначном числе
int DeleteSecondDigit(int number)
{
    int lastNumber = number % 10;
    number = number / 100;

    int newNumber = number * 10 + lastNumber;

    return newNumber;
}

  int randomNumber11 = GetRandomNumber(100, 1000);
    Console.WriteLine(randomNumber11);

    int number11 = DeleteSecondDigit(randomNumber11);
    Console.WriteLine(number11);