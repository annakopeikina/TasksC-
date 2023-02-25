﻿/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Console.WriteLine("Задайте количество строк равное числу столбцов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] spiralMatrix = new int[size, size];

int current = 1;
int i = 0;
int j = 0;

while (current <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
  spiralMatrix[i, j] = current;
  current++;
  if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintMatrix(spiralMatrix);

void PrintMatrix(int[,] spiralMatrix)
{
  for (int i = 0; i < spiralMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < spiralMatrix.GetLength(1); j++)
    {
      if (spiralMatrix[i,j] / 10 <= 0)
      Console.Write($" {spiralMatrix[i,j]} ");

      else Console.Write($"{spiralMatrix[i,j]} ");
    }
    Console.WriteLine();
  }
}
