// Задача 27: Напишите программу,
//  которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("введите число");
int num = int.Parse(Console.ReadLine());

int Sumchisel(int num1)
{
    int sum=0;
    int i=0;
while(num>0)
    {
        sum=sum+num%10;
        num/=10;
    }
    return sum;
}

Console.WriteLine("сумма цифр = " + Sumchisel(num));