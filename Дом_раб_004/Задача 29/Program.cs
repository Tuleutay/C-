// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//Задание должно быть выполнено в методах.
Console.WriteLine("Введите размер массива");
bool isParsed = int.TryParse(Console.ReadLine(), out int lenght);

if(!isParsed)
{
    Console.WriteLine("Не правильно введены данные");
    return;
}
Console.WriteLine("Введите элементы массива");

int[] InputArray(int lenght)
{
    int[] array = new int[lenght];
    for(int i = 0; i < lenght; i++)
    {
        bool isParsed = int.TryParse(Console.ReadLine(), out int number);
        if(!isParsed)
        {
            Console.WriteLine("Не правильно введены данные");
        }
        else array[i] = number;
    }
    return array;
}
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
int[] arr = InputArray(lenght);
PrintArray(arr);
