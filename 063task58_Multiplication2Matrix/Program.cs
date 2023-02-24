/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.WriteLine("Введите количество строк первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы, равное числу строк второй матрицы: ");
int mn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int t = Convert.ToInt32(Console.ReadLine());
int[,] firstMatrix = new int[n, mn];
int[,] secondMatrix = new int[mn, t];
int[,] multipliedMatrix = new int[n,t];
Matrix(firstMatrix);
Console.WriteLine($"\nпервая матрица: ");
PrintMatrix(firstMatrix);

Matrix(secondMatrix);
Console.WriteLine($"\nвторая матрица: ");
PrintMatrix(secondMatrix);

MultiplyMatrix(firstMatrix, secondMatrix, multipliedMatrix);
Console.WriteLine($"\nпроизведение этих матриц: ");
PrintMatrix(multipliedMatrix);


void Matrix(int[,] matrix)
{
    int[,] firstMatrix = new int[n, mn];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
}
void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}
void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] multipliedMatrix)
{
    for (int i = 0; i < multipliedMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multipliedMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i,k] * secondMatrix[k,j];
            }
            multipliedMatrix[i,j] = sum; 
            
        }
    }
}

