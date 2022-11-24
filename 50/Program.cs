// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание,
//   что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int [,] matrix = new int[5, 5];

for (int i = 0; i < matrix.GetLength(0); i++)
{
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
      matrix[i,j] = new Random().Next(100);

   Console.Write(matrix[i,j]+" ");
}
Console.WriteLine();
}

Console.WriteLine("введите значение");
int num = Convert.ToInt32(Console.ReadLine());
int a = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
        if(matrix[i,j] ==num);
        {
          a++;
        }
     
     }
}

if(a>=1)
{
      Console.WriteLine(num+" -> это значение есть");
}
else{
      Console.WriteLine(num+" -> этого значения нет");
}
