//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);


if (num == 1)
{
Console.WriteLine("Понедельник - рабочий день");
}
else if (num == 2)
{
Console.WriteLine("Вторник - рабочий день");
}
else if (num == 3)
{
Console.WriteLine("Среда - рабочий день");
}
else if (num == 4)
{
Console.WriteLine("Четверг - рабочий день");
}
else if (num == 5)
{
Console.WriteLine("Пятница - рабочий день");
}
else if (num == 6)
{
Console.WriteLine("Суббота - выходной");
}
else if (num == 7)
{
Console.WriteLine("Воскресенье - выходной");
}
else if (num > 7 || num < 1)
{
Console.WriteLine("Нет такого дня недели, введите число от 1 до 7");
}