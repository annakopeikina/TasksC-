//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.(Math.Pow(3))
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int cube = (number - number) + 1; cube <= number; cube++)
{
    Console.WriteLine(Math.Pow(cube,3));
}
