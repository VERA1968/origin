
//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.




   
    
int M = 10;
int N = 20; 

 PrintNumbers (M, N);
    

void PrintNumbers(int currentNumber, int endNumber)
    {
        if (currentNumber <= endNumber)
        {
            Console.Write(currentNumber+",");
            PrintNumbers(currentNumber + 1, endNumber); // Рекурсивный вызов
        }
    }

