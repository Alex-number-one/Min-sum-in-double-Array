/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
int count = 0;
int maxElement = 0;
int max = 0;
//int maxElemen2 = 0
int [,] CreateArray(int columns, int rows)
{
    int [,] Array = new int [columns, rows];

    for (int i = 0; i < Array.GetLength(0); i++)
    {
       
        for (int j = 0; j < Array.GetLength(1); j++)
        {
          Array[i, j] = new Random(). Next(0, 10);
          for (int k = 0; k < Array.GetLength(1) - 1; k++)
          {
            if (count == rows)
            {
                if (max > maxElement) maxElement = max;
                max = 0;
            } 
             max += Array[i, k];
            count++;
          }
        }
    Console.WriteLine(maxElement);
    }
    return Array;
}
void PrintArray(int [,] Array)
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
PrintArray(CreateArray(5, 5));

