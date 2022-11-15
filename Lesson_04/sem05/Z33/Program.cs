// Задайте массив. Напишите программу, 
//которая определяет, присутствует ли заданное число в массиве.
int[] numbers = new int[12];
FillArray(numbers);
PrintArray(numbers);

Console.WriteLine("Введите число");
int findNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindNumberInArray(numbers,findNumber));
// метод - находит заданное число в массиве
bool FindNumberInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }
    return false;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
}