// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
using System;

class Program
{
    static void Main()
    {
        // Пример вызова функции Аккермана
        int m = 2;
        int n = 1;

        int result = AckermannFunction(m, n);

        Console.WriteLine($"A({m}, {n}) = {result}");

        Console.ReadLine(); // Для того чтобы консольное окно не закрылось сразу
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}

