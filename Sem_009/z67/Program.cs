/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12 45 -> 9 */

Console.WriteLine("Введите N");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);


int sum = GetSumDigitNumbers(n);
Console.WriteLine(sum);

int GetSumDigitNumbers(int number)
{
    int sum = 0;
    if (number !=0)
    {
        int temp = number % 10;
        number /= 10;
        sum+= temp;
        sum+=GetSumDigitNumbers(number);
    }             
    return sum;                                                                                                
}
                                 



