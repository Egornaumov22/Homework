﻿//  Задайте двумерный массив размером m×n, 
//  заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбоцов:");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
      matrix[i,j] = new Random().Next(-10,10);
   Console.Write(matrix[i,j]+" ");
}
Console.WriteLine();
}
