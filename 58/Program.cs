//  Задайте две матрицы. Напишите программу,
//   которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int [,] matrix = new int[2, 2];
for (int i = 0; i < matrix.GetLength(0); i++)
{
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
      matrix[i,j] = new Random().Next(0,10);
   Console.Write(matrix[i,j]+" ");
}
Console.WriteLine();
}

Console.WriteLine();

int [,] matrix1 = new int[2, 2];
for (int a = 0; a < matrix1.GetLength(0); a++)
{
     for (int b = 0; b < matrix1.GetLength(1); b++)
     {
      matrix1[a,b] = new Random().Next(0,10);
   Console.Write(matrix1[a,b]+" ");
}
Console.WriteLine();
}

Console.WriteLine("________");

int [,] matrix2 = new int[2, 2];

void multiply(int matrix,int matrix1, int matrix2)
{
    for (int x = 0; x < 2; x++)
    {
        for (int y = 0; y < 2; y++)
        {
            
        
               matrix[x,y]=matrix[i,j]*matrix[a,b];
               Console.Write(matrix1[x,y]+" ");
        }
        Console.WriteLine();
    }
}
// вообще 0 идей как технически это сделать
// есть понимание что нужно задать метод при котором также будут создаваться переменные 
// но с использованием введенных данных из предыдущих матриц



// for (int c = 0; c < 2; c++)
// for (int i = 0; i < 2; i++)
// for (int a = 0; a < 2; a++)
// {{{
//      for (int d = 0; d < 2; d++)
//       for (int j = 0; j < 2; j++)
//            for (int b = 0; b < 2; b++)
//      {{{
//       matrix2[c,d] = matrix[i,j]*matrix[a,b];
//    Console.Write(matrix1[c,d]+" ");
// }}}
// Console.WriteLine();
// }}}


