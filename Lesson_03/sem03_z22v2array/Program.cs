// // Задача 22 - Напишите программу, которая 
//принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

// метод массива возведения в квадрат чисел от 1 до N
int [] GetTableOfSquares(int n)
{
    int [] array = new int [n];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = (i+1)*(i+1);
    }
    return array;
}

// метод вывода массива в консоль
int [] result = GetTableOfSquares(n);
PrintArray(result);
void PrintArray(int [] array)
{
    for (int i=0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

}
