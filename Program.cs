/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
using System.ComponentModel.DataAnnotations;
using System.Globalization;

int count = 0;
    int min = 0;
int minSum = int.MaxValue;
int minSum2 = int.MaxValue;

int[,] CreateArray(int columns, int rows)
{
    int min2 = min;
    int[,] Array = new int[columns, rows];
 
    for (int i = 0; i < Array.GetLength(0); i++)
    {
       
        /*for (int k = 0; k < Array.GetLength(0) - 1; k++)
        {
          
            for (int l = 0; l < Array.GetLength(1); l++)
            {
                 
               
                
            }
        }
        */

        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(0, 10);
            min += Array[i, j];

        }
        if (i == 0)
         {
            min2 = min;
             minSum = min;
             minSum2 = min;
         }
        
        if (min2 < min)
        {
        minSum2 = min2;
        }
        else if (min < min2 && min < minSum)
        {
            minSum = min;
            count = i + 1;
        }
        if ( minSum2 < minSum)
        {
        minSum = minSum2;
        count = i + 1;
        }
        
        Console.WriteLine("min is: " + min);
        Console.WriteLine("min2 is: " + min2);
        Console.WriteLine("minSum is: " + minSum);
        Console.WriteLine("count is: " + count);
       min2 = min;
        min = 0;
        if (count == 0) count ++;
        
        
    
    }//Console.WriteLine(minSum);
    return Array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
PrintArray(CreateArray(18, 18));
Console.WriteLine($"The min Sum is: {minSum}");
Console.WriteLine($"The number of row: {count}");
