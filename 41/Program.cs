// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("количество чисел");
int amount =Convert.ToInt32(Console.ReadLine());

int [] array = new int [amount];
for (int m = 0; m < amount ; m++)
{
    Console.WriteLine("Введите число");
    array[m] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();

int higherthanzero =0;
for (int i = 0; i < amount; i++)
{
    if(array[i]>0)
    {
        higherthanzero++;
    }
    Console.Write(array[i]+", ");
}

Console.Write("-> "+higherthanzero);