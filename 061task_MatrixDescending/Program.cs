/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки 
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] RandomMatrix()
{
    int[,] matrix = new int[n,m];
    Random rnd = new Random();
    
    for (int i = 0; i < n; i++)
    {
        for (int j =0; j < m; j++)
        matrix[i,j]= rnd.Next(1, 10);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }

        Console.WriteLine();
    }
}
void SortDescending(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k =0; k < matrix.GetLength(1)-1; k++)
            {
                if (matrix[i,k] < matrix[i,k + 1])
                {
                    int temp = matrix[i,k + 1];
                    matrix[i,k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}
int[,] matrix = RandomMatrix();
PrintMatrix(matrix);
Console.WriteLine("");
SortDescending(matrix);
PrintMatrix(matrix);
