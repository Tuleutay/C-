//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.Write(GetEvenNubers(array));




int GetEvenNubers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
      int number = array[i] % 10;
      if(number % 2 == 0)
      {
        count++;
      }
    }
    return count;
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}