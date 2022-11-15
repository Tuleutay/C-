// Напишите программу замена элементов массива: положительные 
//элементы замените на соответствующие отрицательные, 
//и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] numbers = new int[4];

FillArray(numbers);
PrintArray(numbers);

SignChange(numbers);
PrintArray(numbers);

// метод - меняет знак каждого элемента в массиве

void SignChange(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
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
