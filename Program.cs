
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








//     int[] d = new int[] { 1, 2, 3, 4, 5 }; 

//     PrintArrayReverse(d);


// static void PrintArrayReverse(int[] array)
// {
//     if (array.Length > 0)
//     {
//         Console.Write($"{array[array.Length - 1]} ");
//         PrintArrayReverse(array.Take(array.Length - 1).ToArray()); 
//     }
// }

// int[] arr = new int[5];
// arr[0] = 5;
// arr[1] = 2;
// arr[2] = 7;
// arr[3] = 9;
// arr[4] = 1;
// Console.WriteLine(arr[0]);
// Console.WriteLine(arr[1]);
// Console.WriteLine(arr[2]);
// Console.WriteLine(arr[3]);
// Console.WriteLine(arr[4]);

//int[] arr = new int[5] { 1, 2, 3, 4, 5 };
// int[] arr = { 1, 2, 3 ,4, 5 };
// Console.WriteLine(arr[0]);
// Console.WriteLine(arr[1]);
// Console.WriteLine(arr[2]);
// Console.WriteLine(arr[3]);
// Console.WriteLine(arr[4]);

// int n = 10;
// int[] arr = new int[n];
// int i = 0;

// while (i < n)
// {
//     arr[i] = i + 1;
//     // Console.Write(arr[i]);
//     // Console.Write(" ");
//     Console.Write($" {arr[i]} ");
//     i = i + 1;
// }

// int n = 10;
// int[] array = { 1, 2, 3, 4, 5, 6, 8, 9, 23, 43 };
// int i = 0;

// while(i < n)
// {
//     if(array[i] % 2 == 0)
//     {
//        Console.Write($" {array[i]} "); 
//     }
//     // i = i + 1;
//     i++;

// }

// int n = 5;
// int[] arr = { 1, 4, 8, 3, 9 };
// int i = 0;
// int max = arr[0];

// while(i < n)
// {
//     if(arr[i] > max)
//     {
//         max = arr[i];
//     }
//     i++;
// }
// Console.WriteLine(max);