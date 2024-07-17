
//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.




   
    
// int M = 10;
// int N = 20; 

//  PrintNumbers (M, N);
    

// void PrintNumbers(int currentNumber, int endNumber)
//     {
//         if (currentNumber <= endNumber)
//         {
//             Console.Write(currentNumber+",");
//             PrintNumbers(currentNumber + 1, endNumber); 
//         }
//     }



// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

//    long Ackermann(long m, long n)
//     {
//         if (m == 0) return n + 1; 
//         if (n == 0) return Ackermann(m - 1, 1); 
//         return Ackermann(m - 1, Ackermann(m, n - 1)); 
//     }

     
//     {
//         long m = 3, n = 4; 
//         long result = Ackermann(m, n);
//         Console.WriteLine($"A({m}, {n}) = {result}");
//      }



// Задача 3: Задайте произвольный массив. Выведете его элементы,
//  начиная с конца. Использовать рекурсию, не использовать циклы.
     





   
    
        int[] d = new int[] { 1, 2, 3, 4, 5 }; 

        PrintArrayReverse(d);
    

    static void PrintArrayReverse(int[] array)
    {
        if (array.Length > 0)
        {
            Console.Write($"{array[array.Length - 1]} ");
            PrintArrayReverse(array.Take(array.Length - 1).ToArray()); 
        }
    }
