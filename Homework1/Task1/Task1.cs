﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число:");
string numA = Console.ReadLine();
int a = Convert.ToInt32(numA);

Console.WriteLine("Введите второе число");
string numB = Console.ReadLine();
int b = Convert.ToInt32(numB); 

if (a > b)
{
Console.WriteLine("Первое число больше второго");
}
else
{
Console.WriteLine("Второе число больше первого");
}