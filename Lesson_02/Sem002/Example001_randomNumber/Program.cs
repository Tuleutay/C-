int randomNumber = GetRandomNumber(10, 100);
int GetRandomNumber(int minValue, int maxValue)
{
    Random random = new Random();
    int randomNumber = random.Next(minValue, maxValue);
    return randomNumber;
}
Console.WriteLine(randomNumber);