// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = InputNum ("Введите число M: ");
int n = InputNum ("Введите число N: ");

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

int funAkk (int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    else if (m > 0 && n == 0)
    {
        n = funAkk (m - 1, 1);
        return n;
    }
    else if (m > 0 && n > 0)
    {
        n = funAkk (m, n - 1);
        n = funAkk (m - 1, n);
    }
    return n;
}

Console.WriteLine ($"A ({m}, {n}) = {funAkk (m, n)}");

