// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//Задание должно быть выполнено в методах.
Console.WriteLine("Введите восемь чисел");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);
bool isParsedC = int.TryParse(Console.ReadLine(), out int c);
bool isParsedD = int.TryParse(Console.ReadLine(), out int d);
bool isParsedE = int.TryParse(Console.ReadLine(), out int e);
bool isParsedF = int.TryParse(Console.ReadLine(), out int f);
bool isParsedG = int.TryParse(Console.ReadLine(), out int g);
bool isParsedH = int.TryParse(Console.ReadLine(), out int h);
if(!isParsedA || !isParsedB || !isParsedC || !isParsedD || !isParsedE || !isParsedF || !isParsedG || !isParsedH)
{
    Console.WriteLine("Не правильно введены данные");
    return;
}
int[] arr = { a, b, c, d, e, f, g, h};

void PrintArray(int[] array)
{
    Console.Write("{ ");
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("}");
}
PrintArray(arr);
