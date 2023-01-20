//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);

if (num > 0)
{
string str = num.ToString();
if(str.Length < 3)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine(str[2]);
}

else if (num < 0)
{
string str = num.ToString();
if(str.Length < 4)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine(str[3]);
}