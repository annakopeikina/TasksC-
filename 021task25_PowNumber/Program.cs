//Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число А в натуральную степень B.
//3,5->243(3^5)
//2,4 = 16
Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB > 0)
{
    Console.WriteLine(Math.Pow(numberA,numberB));
}
else
{
    Console.WriteLine("Неправильный ввод");
}