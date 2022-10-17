Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int Q = number % 2;
if (Q > 0)
    {
        Console.WriteLine("нет");
    }
if (Q == 0)
    {
       Console.WriteLine("да");
    }

