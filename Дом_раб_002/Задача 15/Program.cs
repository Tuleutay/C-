Console.WriteLine("напишите цифру");
int number = Convert.ToInt32(Console.ReadLine());
bool DayOff(int number)
{
   int sun = number % 7;
   int sat = number % 6;
   return sun == 0 | sat == 0;
}

bool result = DayOff(number);
if (result) Console.WriteLine("Да");
else Console.WriteLine("нет");