// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ConversionToBinaryNumber(number));


int ConversionToBinaryNumber(int number)
{
    int binaryNumber = 0;
    while (number > 0)
    {
        binaryNumber = binaryNumber + number % 2;
        number = number / 2;
        binaryNumber = binaryNumber * 10;
    }
    // binaryNumber = binaryNumber / 10;
    return binaryNumber;
}

string result = ConvertDecToBinary(4); //вызвали метод
Console.WriteLine(result); //вывели на экран
string ConvertDecToBinary(int number) //объявили метод
{
    string tmp = "";
    while (number > 0)
    {
        int remainder = number % 2;
        number /= 2;
        tmp = remainder.ToString() + tmp;
        
    }
    return tmp; //вернули результат

}