// Задача 34: Задайте массив заполненный случайными
//  положительными трёхзначными числами.
//   Напишите программу, которая покажет количество
//    чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int [] array = new int [6];
int a =0;
for (int i = 0; i < 6; i++)
{
      array[i] = new Random().Next(100,1000);
}
for(int i =0; i < 6; i++)
{
    Console.Write(array[i]+ ", ");
}


for (int i = 0; i < 6; i++)
{
    if(array[i]%2 ==0)
    {
        a++;
    }
}
Console.WriteLine();
Console.WriteLine(a);