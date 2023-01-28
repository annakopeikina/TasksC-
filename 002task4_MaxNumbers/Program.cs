//Напишите программу, которая принимает на вход 3 числа и
//выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int numberA =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное число: ");

if((numberA > numberC) && (numberA > numberB))
{
    Console.WriteLine(numberA);
}
else if((numberB > numberA) && (numberB > numberC))
{
    Console.WriteLine(numberB);
}
else if((numberC > numberA) && (numberC > numberB))
{
    Console.WriteLine(numberC);
}
else
{
    Console.WriteLine("Максимального числа нет.Все три числа равны.");
}
