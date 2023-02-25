/*Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/
Console.WriteLine("Введите натуральное число: ");
int M = 1;
int N = GetNumber("N");
Console.WriteLine(Numbers(N, M));

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

int Numbers(int N, int M)
{
    if (N == M)
    {
        return N;
    }
    else
    {
        Console.Write($"{Numbers(N, M + 1)}, ");
        return M;
    }
}
