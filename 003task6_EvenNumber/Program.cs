//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число четным (делиться ли оно на 2 без остатка).
Console.WriteLine("Введите число для проверки на четность: ");
int numberA =Convert.ToInt32(Console.ReadLine());
if (numberA % 2==0) 
{
    Console.WriteLine("Введенное число четное");
}
else if (numberA % 2 > 0)
{
    Console.WriteLine("Введенное число нечетное");
}
else if (numberA % 2 < 0)
{
    Console.WriteLine("Введенное число нечетное");
}