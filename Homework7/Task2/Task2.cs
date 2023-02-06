/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 */

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i,j] = rnd.Next(0, 100);
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

int GetNumber(string message)
{
    int result = 0;

        while(true)
        {
            Console.WriteLine(message);

            if(int.TryParse(Console.ReadLine(), out result))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ввели не число. Повторите ввод");
            }
        }

     return result;
}

int rowNum = GetNumber("Введите номер строки");
int columnNum = GetNumber("Введите номер столбца");

void FindX(int[,] matrix)
{
    if (rowNum > 0 && rowNum < matrix.GetLength(0) && columnNum > 0 && columnNum < matrix.GetLength(1))
    {
        Console.WriteLine($"Значение элемента в матрице = {matrix[rowNum - 1, columnNum - 1]}");
    }
    else
    {
        Console.WriteLine("В матрице отсутствует запрашиваемая позиция");
    }
}

int[,] matrix = InitMatrix(4, 4);
Console.WriteLine("Матрица:");
PrintMatrix(matrix);
Console.WriteLine();
FindX(matrix);