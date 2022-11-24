/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1 , 7 -> такого числа в массиве нет
1 , 1 -> 1 */

Console.WriteLine("Создаем двумерный массив: введите m - ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите n - ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

Console.WriteLine("Введите позиции элемента в двумерном массиве.");
Console.WriteLine("Введите номер строки эелемента");
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
Console.WriteLine("Введите номер столбца эелемента");
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

if (!isParsedX || !isParsedY)
{
    Console.WriteLine("Ошибка!");
    return;
}
int[,] array = CreateRandom2DArray(m,n);
Print2DArray(array);
if (x>m | y>n) Console.WriteLine("В данном масиве, нет такого элемента");
else Console.Write($"{array[x-1,y-1]} ");



int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1, 10);
        }
    }

    return array;
}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
