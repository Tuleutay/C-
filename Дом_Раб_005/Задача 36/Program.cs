// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество элементов массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write(IndexSumNubers(array));




int IndexSumNubers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
      sum = sum + array[i];
    }
    return sum;
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}