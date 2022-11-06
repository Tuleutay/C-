// Задача 22 - Напишите программу, которая 
//принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.

void TableOfSquares(int number)
{
    int[] array = new int[number + 1];
    for (int i=1; i <= number; i++)
    {
        array[i] = i * i;
        Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Введите число");
bool isParsedN = int.TryParse(Console.ReadLine(), out int N);
if (!isParsedN)
{
    Console.WriteLine("Ошибка! Это не число");
    return;
}
TableOfSquares(N);