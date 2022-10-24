// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
int y = Convert.ToInt32(Console.ReadLine());

int DetermineNumberOfQuarter(int x, int y)

if 
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    if (x > 0 && y > 0)
    {
        return 4;
    }
    
}