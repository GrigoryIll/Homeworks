/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

void AverageOfColumn(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average = (average + matrix[i,j]);
        }
        average = average/matrix.GetLength(1);
        Console.WriteLine($"Среднее арифметическое столбцов: {average}");
    }
}   

int[,] matrix = InitMatrix(4, 4);
Console.WriteLine("Матрица:");
PrintMatrix(matrix);
Console.WriteLine();
AverageOfColumn(matrix);