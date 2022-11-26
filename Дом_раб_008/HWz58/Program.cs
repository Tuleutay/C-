//Задача 58: Задайте две матрицы. Напишите метод, который будет находить произведение двух матриц.
/* Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 int cArr[i,j] = aArr[i,1] * bArr[1,j] + aArr[i,2] * bArr[2,j];
arrA[m,n] arrB[l,k]*/
Console.WriteLine("Введите количество строк двух матриц");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите количество столбцов двух матриц");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}
int[,] arrayA = CreateRandom2DArray(m, n);
int[,] arrayB = CreateRandom2DArray(m, n);
Print2x2DArray(arrayA, arrayB);
int[,] result = GetMultiplication2matrices(arrayA, arrayB);
Print2DArray(result);

int[,] GetMultiplication2matrices(int[,] array1, int[,] array2)
{
    int[,] arrayResult = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int productMatrices = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                productMatrices += array1[i, k] * array2[k, j];
            }
            arrayResult[i, j] = productMatrices;
        }
    }

    return arrayResult;

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

void Print2x2DArray(int[,] array, int[,] array2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.Write("| ");
        for (int k = 0; k < array2.GetLength(1); k++)
        {
            Console.Write($"{array2[i, k]} ");
        }
        Console.WriteLine();
    }
}