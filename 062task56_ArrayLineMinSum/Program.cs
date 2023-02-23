/*Задайте прямоугольный двумерный массив. Напишите программу,
 которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка
*/
Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов не равное количеству строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("__________________");
int[,] matrix = RandomMatrix();
PrintMatrix(matrix);
Console.WriteLine("");
int minLineSum = int.MaxValue,
indexMinLine = 0;
for (int i = 0; i < n; i++)
{
    int lineSum = 0;
    for (int j = 0; j < m; j++)
        lineSum += matrix[i, j];

    if (lineSum < minLineSum)
    {
        minLineSum = lineSum;
        indexMinLine = i;
    }
    Console.WriteLine($" сумма в строке {i+1}: {lineSum}");
}

Console.Write($"Строка с минимальной суммой элементов - {indexMinLine + 1} ");

int[,] RandomMatrix()
{
    int[,] matrix = new int[n, m];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
            matrix[i, j] = rnd.Next(1, 10);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}