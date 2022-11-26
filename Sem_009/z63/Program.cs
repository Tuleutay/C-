/* Задача 63: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

Console.WriteLine("Введите N");
bool isParsedX = int.TryParse(Console.ReadLine(), out int num);
FillNumbers(num,1);
void FillNumbers(int number, int count = 1)
{
    Console.Write($"{count}, ");   
    if (count!=number)
    {
        count++;
        FillNumbers(number,count);
    }
    
}
