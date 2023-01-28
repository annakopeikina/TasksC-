//Напишите программу, которая на вход принимает число (N), а на выходе
//показывает все четные числа от 1 до N.
Console.WriteLine("Введите число N: ");
int number =Convert.ToInt32(Console.ReadLine());

for (int u = number - number; u <= number; u=2 + u++)
{
    Console.WriteLine($"{u} ");
}
