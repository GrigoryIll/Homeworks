/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


int[,] InitMatrix(int rows, int columns)
{
    int start = 1;
    int[,] matrix = new int[rows, columns];
    for (int j = 0; j < columns; j++)
    {
        matrix[0, j] = start;
        start++;
    }

    for (int i = 1; i < rows; i++)
    {
        matrix[i, columns - 1] = start;
        start++;
    }

    for (int j = columns - 2; j >= 0; j--)
    {
        matrix[rows - 1, j] = start;
        start++;
    }

    for (int i = rows - 2; i > 0; i-- )
    {
        matrix[i, 0] = start;
        start++;
    }
    int x = 1;
    int y = 1;
    
    while (matrix[x, y + 1] == 0)
    {
        matrix[x, y] = start;
        start++;
        y++;
    }
    while (matrix[x + 1, y] == 0)
    {
        matrix[x, y] = start;
        start++;
        x++;
    }
    while (matrix[x, y - 1] == 0)
    {
        matrix[x, y] = start;
        start++;
        y--;
    }
    while (matrix[x - 1, y] == 0)
    {
        matrix[x, y] = start;
        start++;
        x--;
    }
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            if (matrix[i, j] == 0)
            {
                matrix[i, j] = start;
            }
        }
    }   

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write(matrix[i, j] + "   ");
            } 
            else if (matrix[i, j] < 100)
            {
                Console.Write(matrix[i, j] + "  ");
            }
            else
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
        Console.WriteLine("");
    }
    return matrix;
}

int[,] matrix = InitMatrix(4, 4);