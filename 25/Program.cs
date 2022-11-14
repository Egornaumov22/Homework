// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("введите число");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("введите степень");
int num2 = int.Parse(Console.ReadLine());


Console.WriteLine(num +", " + num2 + " = " + Powr(num, num2));

int Powr(int a, int b)
{
    int res =1;
    for( int i =0;i<b; i++)
    {
        res *= a;
    }
return res;
}

