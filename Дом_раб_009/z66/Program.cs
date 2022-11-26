/* Задача 66: Задайте значения M и N. Напишите метод, который найдёт сумму натуральных элементов в промежутке от M до N. Через рекурсию!

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


Console.WriteLine("Введите M");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите N");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}
int result = GetSumNumbers(m,n);
Console.Write(result);

int GetSumNumbers(int m, int n)
{
    int sum = 0;
     
    if (m<=n)
    {
        
        sum += m; //1 3
        m++;//2 3
        sum += GetSumNumbers(m,n);
        
    }
    return sum;
}