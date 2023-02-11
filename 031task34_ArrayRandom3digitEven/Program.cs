//Задайте массив, заполненный случайными положительными трёхзначными числами,
//Напишите программу, которая покажет количество четных чисел в массиве.
//[345, 897, 568, 234] ->2
Console.WriteLine("Задайте длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[Length];
Random random = new Random();
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
    Console.Write($"{array[i]}, ");
}
Console.Write("]");

int GetNumberofEven()
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            number = number + 1;
    }
    return number;
}
Console.WriteLine($" -> {GetNumberofEven()}");

