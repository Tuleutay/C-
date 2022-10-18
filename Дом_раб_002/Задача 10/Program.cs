Console.WriteLine("Введите трехзначное число");
int[] array = Convert.ToInt32(Console.ReadLine());
int lengh = array.Lenght;

if (lengh == 3) Console.WriteLine(array[1]);
if (lengh > 3) Console.WriteLine("Ошибка");
if (lengh < 3) Console.WriteLine("Ошибка");



