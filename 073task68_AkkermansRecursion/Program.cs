﻿/*Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
Console.WriteLine("Введите неотрицательные числа \n n = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" и m = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"-> A {n}, {m} = {Akkerman(n, m)}");
int Akkerman(int n, int m)
{
    if (n == 0)
        return m+1;
    else
      if (n != 0 && m == 0)
        return Akkerman(n -1, 1);
    else 
        return Akkerman(n -1, Akkerman(n, m -1));
}
