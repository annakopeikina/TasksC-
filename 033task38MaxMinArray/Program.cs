//Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементом массива.
Console.WriteLine("Задайте длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[Length];
Random random = new Random();
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-60, 30);
    Console.Write($"{array[i]}, ");
}
Console.Write("]");
double FindMax()
{
    double max = 0;
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        return max;
    }
}
double FindMin()
{
    double min = array.Min();

    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];
        }
        return min;

    }
}
Console.Write(FindMax() - FindMin());