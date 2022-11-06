// Задача 23 - напишите программу, которая принимает на вход число(N) 
//и выдает таблицу кубов чисел от 1 до N

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int [] GetTableOfCube(int n)
{
    int [] array = new int [n];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = (i+1)*(i+1)*(i+1);
    }
    return array;
}
int [] result = GetTableOfCube(n);
PrintArray(result);
void PrintArray(int [] array)
{
    for (int i=0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

}

