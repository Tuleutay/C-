/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
 Поиск среднее арифметического в отдельном методе. 
Для создания массива и вывода можно воспользоваться методами из 47 задачи.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.WriteLine("Введите m - ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите n - ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] array = CreateRandom2DArray(m, n);
Print2DArray(array);
PrintArithmeticMean(array);

void PrintArithmeticMean(int[,] array)
{
    double sum = 0;
    double arithmeticMean=0;
    for (var j = 0; j < array.GetLength(1); j++)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];

        }
        arithmeticMean = sum / m;
        Console.Write(string.Format("{0:0.0} ",arithmeticMean));
        //Console.Write($"{arithmeticMean} ");
    }
}

int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

