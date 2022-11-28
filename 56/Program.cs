// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int [,] matrix = new int[4, 3];

for (int i = 0; i < matrix.GetLength(0); i++)
{
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
      matrix[i,j] = new Random().Next(0,10);
   Console.Write(matrix[i,j]+" ");
}
Console.WriteLine();
}


int min=100;
int [] sum = new int [matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    sum[i]=0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
sum[i]+=matrix[i,j];

    }
if(min>sum[i])
{
    min =sum[i];
}
}
Console.WriteLine(min);



// Console.WriteLine("минимальное значение у строки"+(i+1)+" = "+ min);
//не могу понять как сделать чтобы выдавало номер строки