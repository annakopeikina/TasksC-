// Напишите программу, которая на входе принимает два числа и выдаёт, 
//какое число больше, а какое меньше. 
// a = 5; b = 7 --> max = 7
// a = 2; b = 10 --> max =10
// a = -9; b = -3 --> max = -3 
Console.WriteLine("Введите первое число: ");
int numberA =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB =Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine(numberA);
}
else if(numberA < numberB)
{
    Console.WriteLine(numberB);
}
else
{
    Console.WriteLine("Оба числа равны");
}
