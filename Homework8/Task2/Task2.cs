/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i,j] = rnd.Next(0, 10);
            }
        }
        return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }

    Console.WriteLine();
    }
}

void SumOfRow(int[,] matrix)
{   int indexMinRow = 0;
    int minRowSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
         sum += matrix[i,j];
        }
        //Console.WriteLine($"{sum}");
        if (i == 0)
        {
            minRowSum = sum;
        }
        else if (sum < minRowSum)
        {
            minRowSum = sum;
            indexMinRow = i;
        }
    }
    Console.Write($"Строка c наименьшей суммой элементов: {indexMinRow + 1}. ");
}

int[,] matrix = InitMatrix(4, 4);
PrintMatrix(matrix);
Console.WriteLine();
SumOfRow(matrix);
