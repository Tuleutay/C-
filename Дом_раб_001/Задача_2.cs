Console.WriteLine("Введите число А ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA < numberB)
    {
        Console.Write("max = ");
        Console.WriteLine(numberB);
    }
if (numberA > numberB)
    {
        Console.Write("max = ");
        Console.WriteLine(numberA);
    }
if (numberA == numberB)
    {
        Console.WriteLine("Числа ровны");
    }