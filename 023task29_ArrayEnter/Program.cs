//Напишите программу, которая задаёт массив из 8 элементов и
//выводит их на экран.
int []array = new int[8];
Random rnd = new Random();
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0,9);
    Console.Write($"{array[i]},");
}
Console.Write("]");