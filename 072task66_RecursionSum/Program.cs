/* Задайте значения M и N. Напишите программу,
 найдёт сумму натуральных элементов в промежутке
 от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Повторите ввод");
        }
    }
    return result;
}

int SumAmong(int M, int N)
{
    if (M == N)
        return N;

    return N + SumAmong(M, N - 1);
}
Console.WriteLine("Введите натуральные числа oт: ");
int M = GetNumber("M");
Console.WriteLine("до: ");
int N = GetNumber("N");
Console.WriteLine(SumAmong(M, N));
