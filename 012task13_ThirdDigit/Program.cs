//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number >= 1000) 
{                                 
   number = number / 10;  
}    
 
if ((number < 1000)&&(number > 100))
{
    Console.WriteLine(number % 10);
}
if (number < 100)
{
     Console.WriteLine("Третьей цифры нет.");
}
