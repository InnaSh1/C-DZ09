// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 


int m = InputNum ("Введите число M: ");
int n = InputNum ("Введите число N: ");

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

int SumNbr (int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else 
    {
        n += SumNbr (m, n-1);
    }
    return n;
}

Console.Write ($"Сумма чисел от {m} до {n} = {SumNbr (m, n)}");

