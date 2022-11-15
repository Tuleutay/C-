//string[,] table = new string[2, 5];
//table[1, 2] = "text";
//
//for (int rows = 0; rows < 2; rows++)
//{
//    for (int columns = 0; columns < 5; columns++)
//    {
//        Console.WriteLine($"-{table[rows, columns]}-");
//    }
//
//}

int [,] matrix = new int[3, 4];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
        }
    }

}

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

//void PrintImage(int[,] matr) метод рисования массива
//{
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//           if(image[i,j] == 0) Console.Write($" ");
//            else Console.Write($"+"");
//        }
//        Console.WriteLine();
//    }
//}

//void FillImage(int row, int col) метод заливки
//{
//    if(pic[row, col] == 0)
//    {
//        pic[row, col] = 1;
//        FillImage(row - 1, col);
//        FillImage(row, col - 1);
//        FillImage(row + 1, col);
//        FillImage(row, col + 1);
//    }
//}