// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


class Program
{
    static void Main()
    {
        // Задайте значения M и N
        int M = 2;
        int N = 11;

        // Вызов метода для вывода натуральных чисел в заданном промежутке
        PrintNumbersInRange(M, N);

        Console.ReadLine(); // Для того чтобы консольное окно не закрылось сразу
    }

    // Рекурсивный метод для вывода натуральных чисел в заданном промежутке
    static void PrintNumbersInRange(int start, int end)
    {
        if (start <= end)
        {
            Console.WriteLine(start);
            PrintNumbersInRange(start + 1, end);
        }
    }
}

