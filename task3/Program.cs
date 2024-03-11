// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
using System;

class Program
{
    static void Main()
    {
        // Пример задания произвольного массива
        int[] array = { 1, 7, 3, 9, 5 };

        // Вывод элементов массива с использованием рекурсии
        PrintArrayReversed(array, array.Length - 1);

        Console.ReadLine(); // Для того чтобы консольное окно не закрылось сразу
    }

    // Рекурсивный метод для вывода элементов массива с конца
    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayReversed(arr, index - 1);
        }
    }
}
