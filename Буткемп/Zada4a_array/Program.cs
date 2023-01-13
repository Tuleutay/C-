// Сумма 10 подряд идущих элементов в массиве, max sum
// array 10
//m -3

//int[] array = { 5, 4, 2, 1, 6, 8, 2, 3, 4, 6};
//int GetMaxSum(int[] array)
//{
//    int maxSum =0;
//    int s=0;
//    for (int i=0; i<array.Length-3; i++)
//    {
//        s=array[i]+array[i+1]+array[i+2];
//        if (s>maxSum) maxSum=s;
//     
//    }
//    return maxSum;
//}//

//int result = GetMaxSum(array);
//Console.WriteLine(result);

/* ----- Решение Сергея   */
using System.Diagnostics;

int size = 10;

int m = 3;

int[] array = Enumerable.Range(1,size)
                        .Select(item => Random.Shared.Next(10))
                        .ToArray();

Console.WriteLine($"[{string.Join(", ", array)}]");
/*
Stopwatch sw = new();
sw.Start();

int max = 0;
for (int i = 0; i < array.Length - m; i++)
{
    int t = 0;
    for (int j = i; j < i+m; j++)
    {
        t += array[j];
    }
    if (t > max) max = t;
}
sw.Stop();
Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
Console.WriteLine(max);
*/



Stopwatch sw = new();
sw.Start();

int max = 0;
for (int i = 0; i < m; i++) max += array[i];
int t = max;
for (int j = 1; j < array.Length - m; j++)
{
    t = t - array[j - 1] + array[j + (m-1)];
    if (t > max) max = t;
}


sw.Stop();
Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
Console.WriteLine(max);