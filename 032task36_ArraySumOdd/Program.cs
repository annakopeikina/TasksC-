//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Задайте длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Length];
Random random = new Random();
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-100, 100);
    Console.Write($"{array[i]},");
}
Console.Write("]");

int SumOddNumbers()
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {

        sum += array[i];

    }
    return sum;
}
Console.WriteLine(SumOddNumbers());