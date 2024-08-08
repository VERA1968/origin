
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
//        Console.Write($" {" array[i]} "); 
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



//Создание массива и вывод в терминал его содержимого.
// проверить число n присутствует в массиве или нет.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[]array = new int[size];
//     Random random = new Random();
//     for(int i = 0; i < array.Length;i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[]array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] +" ");
//     }
//     System.Console.WriteLine();
// }

// bool SearchNum(int[] array, int num)
// {
//   for(int i = 0; i < array.Length; i++) 
//    {
//         if(array[i] == num)
//         {
//             return true;
//         }
//    }
//    return false;
// }


//  System.Console.WriteLine("Input size of array: ");
//  int size = Convert.ToInt32(Console.ReadLine());
//  System.Console.WriteLine("Input minimal value of array element: ");
//  int min = Convert.ToInt32(Console.ReadLine());
//  System.Console.WriteLine("Input maximal value of array element: ");
//  int max = Convert.ToInt32(Console.ReadLine());



//  int[] myArray = CreateRandomArray(size, min, max);
//  PrintArray(myArray);

//  System.Console.WriteLine("Input number: ");
//  int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(SearchNum(myArray, num));


//Задайте массив из 10 элементов, заполненный числами из промежутка
//[-10, 10]. Замените отрицательные элементы на положительные,
// а положительные на отрицательные.
// Пример 
// [1 -5 6]
// => [-1 5 -6]

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[]array = new int[size];
//     Random random = new Random();
//     for(int i = 0; i < array.Length;i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[]array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] +" ");
//     }
//     System.Console.WriteLine();
// }
// int[] HangeArray(int[] array)
// {
//   for(int i = 0; i < array.Length; i++) 
//     {       
//         array[i] *= -1;        
//     }
//    return array;
// }        



//  System.Console.WriteLine("Input size of array: ");
//  int size = Convert.ToInt32(Console.ReadLine());
//  System.Console.WriteLine("Input minimal value of array element: ");
//  int min = Convert.ToInt32(Console.ReadLine());
//  System.Console.WriteLine("Input maximal value of array element: ");
//  int max = Convert.ToInt32(Console.ReadLine());



//  int[] myArray = CreateRandomArray(size, min, max);
//  PrintArray(myArray);
//  myArray = HangeArray(myArray);
//  PrintArray(myArray);




// Найдите произведение пар чисел в одномерном массиве.Парой считается
// первый и последний элемент,второй и предпоследний и т.д.
// Результат записать в новый массив.


//Напишите программу,которая принимает на вход число,
//и выдает колличество цыфр в числе.


// using System.Globalization;

// int DigitCounter(int num)
// {
//     int counter = 0;
//     while (num > 0)
//     {
//         num /=10;
//         counter++;
//     }
//     return counter;
// }


// System.Console.WriteLine("Input number: ");
//  int num = Convert.ToInt32(Console.ReadLine());

//  System.Console.WriteLine(DigitCounter(num));

// Задайте массив из N случайных целых чисел
//  (N вводится с клавиатуры).
//  Найдите колличество чисел, которое оканчивается на 1 
//   и делится нацело на 7.
//   Пример:
//   [1 5 11 21 81 4 0 91 2 3] => 2

// Cоздали массив и заполнили его значениями с клавиатуры.


// int[] InputArray(int size)
// {
//     int[] arr = new int [size];

//     for(int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"Input {i+1} number: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }


// int ArrayCounter (int[] arr)
// {
//     int count = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] % 10 == 1 && arr[i] % 7 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine()); 

// int[] arr = InputArray(size);
// System.Console.WriteLine(ArrayCounter (arr)); 


//Заполните массив из N случайных чисел,(вводится с консоли  не более 8)
// 0т 0 до 9.Сформируйте целое число,
// которое будет состоять из чисел из массива.Старший разряд числа
// находится на нулевом индексе, младший на последнем.
// пример: [1 4 5 2 6] => 14526

// int[] CreateRandomArray(int size)
// {
//     int[]array = new int[size];
//     Random random = new Random();
//     for(int i = 0; i < array.Length;i++)
//     {
//         array[i] = random.Next(0 , 9 + 1);
//     }
//     return array;
// }


// void PrintArray(int[]array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] +" ");
//     }
//     System.Console.WriteLine();
// }

// int NumberOfArray(int[] array)
// {
//     int number = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         number +=array[i] * (int)(Math.Pow(10,array.Length-i-1));
//     }
//     return number;
// }
// Console.WriteLine("Input size of array: ");
//  int size = Convert.ToInt32(Console.ReadLine());



// int[] myArray = CreateRandomArray(size);
// int result = NumberOfArray(myArray);
//  PrintArray(myArray);
// Console.WriteLine(result);



//ДВУМЕРНЫЕ МАССИВЫ

//создание и заполнение двумерного массива.

// int[,] matrix = new int [3, 5];

// Random random = new Random();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = random.Next(1, 11);
//     }
// }
// //Вывод массива на экран.

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }


// ЗАПОЛНЕНИЕ И ВЫВОД ДВУМЕРНОГО МАССИВА С ПРИМЕНЕНИЕ ФУНКЦИИ.

// int[,] CreateMatrix (int rowCount, int columsCount)  //функция
// {
//     int[,] matrix = new int [rowCount,columsCount];

//     Random random = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = random.Next(1, 11);
//         }    
//     }
//     return matrix;
// }

// // код для вывода массива на экран в виде функции.

// void ShowMatrix(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     } 
// }

// int[,] matrix = CreateMatrix(5,8);
// ShowMatrix(matrix);

//Задача: Создать двумерный массив. Найти сумму цыфр числа.Вввести на экран
// четные элементы массива.

// using System.Data;

// int[,] CreateMatrix (int rowCount, int columsCount)  //функция
// {
//     int[,] matrix = new int [rowCount,columsCount];

//     Random random = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = random.Next(1, 1000);
//         }    
//     }
//     return matrix;
// }


// void ShowMatrix(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     } 

// } 

//  int[,] matrix = CreateMatrix(5, 4);
//   ShowMatrix(matrix);

//  foreach (int e in matrix)
//  {
//     if (IsInTerestihg(e) )
//     {
//         Console.WriteLine( e );       
//     }
//  }

// bool IsInTerestihg(int value)
// {
//     int sumVidigits =  GetsumVidigits(value);
//     if(sumVidigits % 2 == 0)
//     {
//         return true;
//     }  
//      return false; 
// }   

//   int GetsumVidigits(int value) // Функция для нахождения суммы цыфр числа
//  {
//     int sum = 0;
//     while(value > 0)
//     {
//         sum = sum | value % 10;
//         value = value / 10;
//     }
//     return sum;
//  }



//Cтроки в C#.

//    string str = "Hello world!";
//    Console.Write(str[0]);

//Cоздание строки в С#.
//  string s1 = "hello";

//  char[] ch_array = { 'w', 'o', 'r', 'i', 'd'};
//  string s2 = new String(ch_array);

//  string s3 = new string('a', 6); // Результатом будет "аааааа"

//    string CreateString(string s) 
//    {
//         string Letters = "";
//         foreach (char e in s)
//         {
//             if( char.IsAsciiLetter(e))
//             {
//                 Letters = Letters + e;
//             }
//         }
//         return Letters;
//    }

//     string str = Console.ReadLine();
//     string result = CreateString(str); 
//     Console.WriteLine(result);




// public class Program
// {
//     public static void Main()
//     {
//         // Пример строки
//         string inputString = "Hello, my name is John and I am 27 years old.";

//         // Функция для поиска цифр
//         string[] foundDigits = FindDigits(inputString);

//         // Вывод результатов
//         foreach (var digit in foundDigits)
//         {
//             Console.WriteLine(digit);
//         }
//     }
// }


// Бесконечный цикл. Остановка цикла.

// while (true)
// {
//     Console.WriteLine("i am in joop!");
//     break;
// }


// Задача:выдать на экран сообщение 
// в случае наличия в массиве нечетного числа.

// Console.WriteLine("Start");

// int[] numbers = {2, 4, 6, 7, 8, 10};
// foreach (int number in numbers)
// {
//     if (number % 2 == 1)
//     {
//         Console.WriteLine("There is odd number");
//         break;
//     }
// }
// Console.WriteLine("Stop");

// Задача: Сообщить о наличии отрицательных элементах
//  в строках двумерного массива.

// int[,] table = {
//     { 1, 1,  1},
//     { 2, -2, 2},
//     { 3, 3, -3} };

// for (int i = 0; i < table.GetLength(0); i++) 
// {
//     for (int j = 0; j < table.GetLength(1); j++) 
//     {
//         if (table[i, j] < 0)
//         {
//             Console.WriteLine($"There are negative in line {i}");
//             break;
//         }

//     }
// }  
  

  // Cоздание и заполнение двумерного массива.

//   int[,] CreateRandomMatrixint(int rows, int colums, int min,int max)

//   {
//      int[,] matrix = new int [rows,colums];
//      Random random = new Random();
//      for (int i = 0; i < rows; i++)
//      {
//         for (int j = 0; j < colums; j++)
//         {
//             matrix[i, j] = random.Next(min, max + 1);
//         }
//      }
//      return  matrix;
//   }

//   void PrintMatrix(int[,] matrix)
//   {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//   }

//   PrintMatrix(CreateRandomMatrixint(4, 4, 0, 9));