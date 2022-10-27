Console.WriteLine("введите число");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA>7)
{
    Console.WriteLine("не является днем недели");
}
else
{
    if(numberA ==6|| numberA ==7)
    {
        Console.WriteLine("-> да");
    }
    else
    {
        Console.WriteLine("-> нет");
    }
}
