// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса нечетные , и замените эти элементы на их
// квадраты.
// Например, изначально массив выглядел вот так:
// 1 47 2
// 5 92 3
// 8 42 4

Console.WriteLine("Введите m - ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите n - ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] array = CreateRandom2DArray(m,n);
Print2DArray(array);
ChangeOddElementsWithSquares (array);
Console.WriteLine();
Print2DArray(array);
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

void  ChangeOddElementsWithSquares (int [,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 == 1 && j % 2 == 1)
            {
                array [i, j] *= array[i, j]; 
            }
        }
    }
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

