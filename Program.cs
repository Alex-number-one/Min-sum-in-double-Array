﻿/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
using System.Globalization;

int count = 0;
int max2 = 0;
    int max = 0;
int maxElement = 0;
int maxElement2 = 0;
int[,] CreateArray(int columns, int rows)
{
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
            max += Array[i, j];

        }
        
        
        if (max2 > max)
        {
        maxElement2 = max2;
        }
        else if (max > max2 && max > maxElement)
        {
            maxElement = max;
            count ++;
        }
        if ( maxElement2 > maxElement)
        {
        maxElement = maxElement2;
        count++;
        }
        Console.WriteLine("max is: " + max);
        Console.WriteLine("max2 is: " + max2);
        Console.WriteLine("maxElement is: " + maxElement);
       max2 = max;
        max = 0;
        
        
        
    
    }//Console.WriteLine(maxElement);
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
Console.WriteLine(maxElement);
