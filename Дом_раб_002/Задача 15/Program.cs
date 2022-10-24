Console.WriteLine("напишите цифру");
int number = Convert.ToInt32(Console.ReadLine());
bool DayOff(int number)
{
   return number == 6 | number == 7;
}

bool result = DayOff(number);
if (result) Console.WriteLine("Да");
else Console.WriteLine("нет");