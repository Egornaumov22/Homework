// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());

// метод стринг позволяет нам работать с данными как со знаками или последовательностью знаков, а не числами?
  
  string Downnumbers(int start, int end)
  {
if(end==start)
{
return end.ToString();
}
return (start+" "+Downnumbers(start-1,end));
  }
  Console.WriteLine(Downnumbers(num,1));











  