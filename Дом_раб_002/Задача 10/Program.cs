Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
number = number / 10;
int secondNumber = number % 10;
if (number < 10)
{
    Console.WriteLine("Ошибка");
}
else if (number > 99)
{
    Console.WriteLine("Ошибка");
}
else
{
   Console.WriteLine(secondNumber); 
} 