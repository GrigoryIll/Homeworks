/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumOfNumbers(int m, int n, int sum, int i)
{
    while (i >= m && i <= n)
    { 
        sum = sum + i;
        i++;
    }
    return sum; 
}

int result = SumOfNumbers(4, 8, 0, 4);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равно: {result}");
