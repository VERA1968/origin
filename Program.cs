
//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        int M = 10; // Пример значения M
        int N = 20; // Пример значения N

        PrintNumbers(M, N);
    }

    private static void PrintNumbers(int currentNumber, int endNumber)
    {
        if (currentNumber <= endNumber)
        {
            Console.Write(currentNumber+",");
            PrintNumbers(currentNumber + 1, endNumber); // Рекурсивный вызов
        }
    }
}
