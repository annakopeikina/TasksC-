﻿/*Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/
Console.WriteLine("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int M = 1;
if (N < 1)
{
    Console.WriteLine("Некорректный ввод");
    
}


int Numbers(int N, int M)
{
    if (N == M)
    {
    return N;
    }
    else
    {
     Console.Write($"{Numbers(N, M+1)}, ");
     return M;
    }
}
Console.WriteLine(Numbers(N,M));

