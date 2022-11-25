/* Задача 56: Задайте двумерный массив. Напишите метод, 
который будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов: 1 строка */

Console.WriteLine("Введите количество строк");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите количество столбцов");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] array = CreateRandom2DArray(m, n);
Print2DArray(array);

Console.WriteLine();
int[] sumArray = GetSumRowNumbers(array);
PrintArray(sumArray);
int minSumRow = GetRowMinSum(sumArray);
Console.WriteLine($"{minSumRow} строка с наименьшей суммой");

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }

}
int[] GetSumRowNumbers(int[,] array)
{
    int[] sumRow = new int[array.GetLength(0)];
    int index = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        sumRow[index] = sum;
        index++;
        sum = 0;
    }
    return sumRow;
}
int GetRowMinSum(int[] array)
{
    int minSum = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minSum)
        {
            index = i;
        }
    }
    return index+1;
}

int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}