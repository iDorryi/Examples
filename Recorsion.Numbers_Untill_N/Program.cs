﻿// Console.WriteLine("Введите N");
// int N = Convert.ToInt32(Console.ReadLine());
// string NumbersUntillN ( int start, int end)
// {
//     if(start == end)
//     return start.ToString();
//     return (start + "," + NumbersUntillN(start + 1, end ));
// }
// Console.WriteLine($"Номера до N это: {NumbersUntillN (1, N)}");

Console.WriteLine("Введите M");
Console.WriteLine("Введите N");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
string NumbersUntillN ( int M, int N)
{
    if(M == N)
    return M.ToString();
    return (M + "," + NumbersUntillN(M + 1, N ));
}
Console.WriteLine($"Номера от M до N это: {NumbersUntillN(M, N)}");


