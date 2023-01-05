// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int n = InputNum ("Введтите число N: ");

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

int NatNbrRev (int num)
{
    if (num == 1)
    {
        return 1;
    }
    else 
    {
        Console.Write ($"{num}, ");
        num = NatNbrRev (num-1);
    }
    return num;
}

Console.WriteLine (NatNbrRev (n));

