//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.WriteLine("Введите первое число:");
string numA = Console.ReadLine();
int a = Convert.ToInt32(numA);

Console.WriteLine("Введите второе число");
string numB = Console.ReadLine();
int b = Convert.ToInt32(numB); 

Console.WriteLine("Введите третье число");
string numC = Console.ReadLine();
int c = Convert.ToInt32(numC); 

if (a > b && a > c)
{
Console.WriteLine("Первое число максимальное");
}
else if (b > a && b > c)
{
Console.WriteLine("Второе число максимальное");
}
else if (c > a && c> b)
{
Console.WriteLine("Третье число максимальное");
}