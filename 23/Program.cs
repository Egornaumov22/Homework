Console.WriteLine("введите число");
int num =int.Parse(Console.ReadLine());

int num1 =1;

while(num1<=num)
{
    Console.Write(Math.Pow(num1,3)+(", "));
    num1++;
}