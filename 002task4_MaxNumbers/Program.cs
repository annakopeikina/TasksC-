//Напишите программу, которая принимает на вход 3 числа и
//выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int numberA =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное число: ");
if(numberA > numberB > numberC)
{
    Console.WriteLine(numberA);
}
else if(numberB > numberC > numberA)
{
    Console.WriteLine(numberB);
}
else if(numberC > numberB > numberA)
{
    Console.WriteLine(numberC);
}
else 
{
    Console.WriteLine("Все числа равны");
}
