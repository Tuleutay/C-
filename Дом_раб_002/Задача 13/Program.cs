
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());


 int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    int lastValue = number % 10;
    array[i] = lastValue;
    number = number / 10;
   }
if (array[2]==0 & array[3]==0 & array[4]==0 & array[1]==0) Console.WriteLine("Третьей цифры нет");
else if (array[2]==0 & array[3]==0 & array[4]==0) Console.WriteLine("Третьей цифры нет");
else if (array[3]==0 & array[4]==0) Console.WriteLine(array[0]);
else if (array[4]==0) Console.WriteLine(array[1]);
else Console.WriteLine(array[2]);
