﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] arrayDDD = new int [2,2,2];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int n = 0; n < 2; n++)
        {
            arrayDDD[i,j,n] = new Random().Next(10);
            if(arrayDDD[i,j,n]==arrayDDD[i,j,n])
            {
arrayDDD[i,j,n] = new Random().Next(10);
            }
   Console.Write(arrayDDD[i,j,n]+" ");
        }
        Console.WriteLine();
    }
}
// не понимаю я просто честно, как сделать это нет просто знаний у меня, я понимаю, что нужно сделать проверку на равнозначность элементов массива
//  и если они равны то заменить его другим рандомным и так пока они все не будут разными
//  далее нужно просто вывести массив и снова вместе с индексами каждого элемента, что не получилось у меня в предыдущих задачах









