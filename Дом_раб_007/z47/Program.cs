// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
//Сделать отдельный метод который генерирует двумерный массив и отдельный метод который выводит его на экран.
//m и n вводит пользователь в консоль

Console.WriteLine("Введите m - ");
bool isParsedM = double.TryParse(Console.ReadLine(), out double m);
Console.WriteLine("Введите n - ");
bool isParsedN = double.TryParse(Console.ReadLine(), out double n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

double[,] array = CreateRandomRealNum2DArray(m, n);
Print2DArray(array);

double[,] CreateRandomRealNum2DArray(double m, double n)
{
    double[,] array = new double[3, 4];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.NextDouble() + random.Next(-10, 10);
        }
    }

    return array;
}

void Print2DArray(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0:0.00} ",array[i, j]));
        }
        Console.WriteLine();
    }
}