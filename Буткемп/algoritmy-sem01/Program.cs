﻿/*
типы алгоритмов:
1 - константные
2 - логарифмические число от 0 до 100(3) - больше 50? нет - больше 25? нет - log2(n) 7 раз
3 - линейный y = kx + b пример по циклу for
4 - линейно-логорифмический (быстрая сортировка, сортировка слиянием)
5 - квадратичный двумерный массив(цикл в цикле)
6 - кубический трехмерный массив (цикл в цикле)
*/

// НОД (Алгоритм Эвклида)
// НОД (14,21) = 7
int n = 140;
int m = 175;
int count = n * m;
while (n != m)

{
    if (n >m)
    {
        n = n - m;
    }
    else
        m = m - n;

    //Console.WriteLine(n);
    //Console.WriteLine(m);
    //Console.WriteLine(); НОД
}
//НОК
Console.WriteLine(count/n);