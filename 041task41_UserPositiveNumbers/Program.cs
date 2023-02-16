//Пользователь вводит с клавиатуры М чисел. Посчитайте,
//сколько чисел больше 0 ввел пользователь.
//0,7,8,-2,-2,->2
//1,7,567,89,223->5
Console.WriteLine("Введите через пробел несколько целых чисел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > 0)
        {
           count++;
        }
    }        
Console.WriteLine($"{count} чисел больше нуля");




