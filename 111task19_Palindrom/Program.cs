//Напишите программу, которая принимает на ввод натуральное число и
//проверяет, является ли оно палиндромом.
//14212->нет
//12821->да
//23432->да

Console.WriteLine("Введите натуральное пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberFirst = number / 10000 % 10;
int numberSecond = number / 1000 % 10;
int reverseBeforeLast = number / 10 % 10;
int reverseLast = number % 10;
    if  (number > 99999)(number < 10000);
    {
      Console.WriteLine("Неверный ввод");
    }

    if  (numberFirst == reverseLast && numberSecond == reverseBeforeLast)
      {
        Console.WriteLine("Введенное число - палиндром");
      }
    else
      {
        Console.WriteLine($"Введенное число - не палиндром");
      }
    