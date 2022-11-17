// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве. 
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

Console.WriteLine("Введите количество элементов массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[len];
FillArray(numbers);
PrintArray(numbers);
int [] arr = new int[count];
int[] arrayOfProduct = ProductNumberArr(int[] numbers);
PrintArray(arrayOfProduct);


int count = len/2;
if (len%2 != 0)
{
    count++;
}


int[] ProductNumberArr(int[] array, int ccol)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = array[i]*array[array.Length-i-1];
    }
    return arr;
}




void FillArray(int[] array)
{
    Random random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}