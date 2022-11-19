// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным
//  элементов массива.

// [3 7 22 2 78] -> 76


int [] array = new int [10];

for (int i = 0; i < 10; i++)
{
      array[i] = new Random().Next(-100, 100);
}
for(int i =0; i < 10; i++)
{
    Console.Write(array[i]+ ", ");
}

Console.WriteLine();
int max=0;
int min=0;
for (int i = 0; i < 10; i++)
{
    if(array[i]>max)
    {
        max=array[i];
    }
    else
    {
if(array[i]<min)
{
    min=array[i];
}
    }
}
Console.WriteLine("min= "+min+", "+"max= "+max);