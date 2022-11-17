// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] numbers = new int[5];

FillArray(numbers);
PrintArray(numbers);

Console.WriteLine();

int[] copyArray = CopyArray(numbers);
PrintArray(copyArray);

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 11);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}