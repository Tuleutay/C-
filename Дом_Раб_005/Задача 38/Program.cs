// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.WriteLine("Введите количество элементов массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write(DiffMaxMinNubers(array));


int DiffMaxMinNubers(int[] array)
{
    int maxNum = array[0];
    int minNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
      if(maxNum < array[i])
      {
        maxNum = array[i];
      }
      if(minNum > array[i])
      {
        minNum = array[i];
      }
    }
    
    int diff = maxNum - minNum;
    return diff;
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}