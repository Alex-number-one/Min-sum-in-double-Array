/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
int count = 0;
int max2 = 0;
int max = 0;
int maxElement = 0;
//int maxElemen2 = 0
int[,] CreateArray(int columns, int rows)
{
    int[,] Array = new int[columns, rows];

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int k = 0; k < Array.GetLength(0) - 1; k++)
        {
            for (int l = 0; l < Array.GetLength(1); l++)
                if (i != 0) max2 += Array[k, l];


        }

        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(0, 10);
            max += Array[i, j];



        }
        Console.WriteLine();
        if (max2 > max) maxElement = max2;
        else maxElement = max;
        Console.WriteLine("max is: " + max);
        Console.WriteLine("max2 is: " + max2);
        max = 0;
        max2 = 0;
    }
    //Console.WriteLine(maxElement);
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
PrintArray(CreateArray(2, 2));

Console.WriteLine(maxElement);