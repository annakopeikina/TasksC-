/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.WriteLine("Задайте размер XYZ массива \nЗадайте x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте z: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] array3d = new int[x, y, z];
CreateArray(array3d);
PrintArray(array3d);
void CreateArray(int[,,] array3d)
{
    int[] unique = new int[array3d.GetLength(0) * array3d.GetLength(1) * array3d.GetLength(2)];
    int number;
    Random rnd = new Random();
    for(int i = 0; i < unique.GetLength(0); i++)
    {
        unique[i] = rnd.Next(10,100);
        number = unique[i];
        if (i >= 1)
        {
            for (int j = 0; j <i; j++)
            {
                while (unique[i] == unique[j])
                {
                    unique[i] = rnd.Next(10,100);
                    j = 0;
                    number = unique[i];
                }
                number = unique[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3d.GetLength(0); x++)
    {
        for (int y = 0; y < array3d.GetLength(1); y++)
        {
            for (int z = 0; z < array3d.GetLength(2); z++)
            {
                array3d[x, y, z] = unique[count];
                count++;
            }
        }
    }
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array3d[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

