/* Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента или же
  указание, что такого элемента нет.
Например, задан массив:
1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
Console.WriteLine("Введите номер строки: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int colomn = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[8, 8];
FillArrayRandomNumbers(numbers);

if (line > numbers.GetLength(0) || colomn > numbers.GetLength(1))
{
    Console.WriteLine("-> такого числа в массиве нет.");
    Console.WriteLine("");
}
else
{
    Console.Write($"На строке {line} в столбце {colomn} расположено число {numbers[line - 1, colomn - 1]}");
}
Console.WriteLine("");
PrintArray(numbers);
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100)/10;
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "     ");
        }
        Console.WriteLine(" ");
    }

}