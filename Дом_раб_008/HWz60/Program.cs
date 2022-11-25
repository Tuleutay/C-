/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите метод, который 
будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Console.WriteLine("Введите 1 параметр трехмерного массива");
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
Console.WriteLine("Введите 2 параметр трехмерного массива");
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);
Console.WriteLine("Введите 3 параметр трехмерного массива");
bool isParsedZ = int.TryParse(Console.ReadLine(), out int z);

if (!isParsedX || !isParsedY || !isParsedZ)
{
    Console.WriteLine("Ошибка!");
    return;
}
int[,,] result = CreateRandom3DArray(x, y, z);
Print3DArray(result);



void Print3DArray(int[,,] array)
{
    int[,] printArray = new int[4, 2];
    for (int z = 0; z < 2; z++)
    {
        for (int x = 0; x < 2; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                Console.Write($"{array[x, y, z]}({x}, {y}, {z}) ");
            }
            Console.WriteLine();
        }
    }
}


int[,,] CreateRandom3DArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = random.Next(1, 100);
            }
        }
    }
    return array;
}
