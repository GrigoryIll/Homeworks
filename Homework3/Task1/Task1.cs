/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

string str = number.ToString();
{
    if (str.Length == 5 && str[0] == str[4] && str[1] == str[3])
    Console.WriteLine("Число является палиндромом");
    else 
    Console.WriteLine("Число не является палиндромом или не пятизначное"); 
}