//Напишите программу, которая выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.

int[] arrayNum = GenerateArray();

int[] GenerateArray()
{
    int[] arrayNum = new int[8];
    Random random = new Random();
    for (int i=0; i < arrayNum.Length; i++)
    {
        arrayNum[i] = random.Next(0, 2);
    }
    return arrayNum;
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        Console.Write(" ");
        position++;
    }
}
PrintArray(arrayNum);