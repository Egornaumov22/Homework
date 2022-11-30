// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите число 1");
int num1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num2=Convert.ToInt32(Console.ReadLine());


int sumnumbers(int start, int end)
{
if(start==end)
{
    return end;
}
return (start+sumnumbers(start+1,end));
}

Console.WriteLine(sumnumbers(num1,num2));








