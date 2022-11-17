// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива");
bool isParsed = int.TryParse(Console.ReadLine(), out int lenght);

if(!isParsed)
{
    Console.WriteLine("Не правильно введены данные");
    return;
}
Console.WriteLine("Введите элементы массива");
int[] arr = InputArray(lenght);
PrintArray(arr);
int x = GetPositiveNumber(arr);
Console.WriteLine($" {x}");

int GetPositiveNumber(int[] array)
{
    int count = 0;
    for (int  i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

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
