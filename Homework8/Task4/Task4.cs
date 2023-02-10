/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

HashSet <int> uniqueNumbers = new HashSet<int> ();
Random rnd = new Random();
int GenerateUniqueNumbers()
{
    while (true)
    {
        int num = rnd.Next(10, 99);
        if (!uniqueNumbers.Contains(num))
        {   
            uniqueNumbers.Add(num);
            return num;
        }
    }
}

int[,,] InitMatrix(int x, int y, int z)
{
    int[,,] matrix = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
            matrix[i, j, k] = GenerateUniqueNumbers();
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {    
            for (int k = 0; k < matrix.GetLength(2); k++)
            Console.Write($"{matrix[i, j, k],1}({j},{k},{i}) "); 
            Console.WriteLine();
        }
    }
}

int[,,] matrix = InitMatrix(2, 2, 2);
PrintMatrix(matrix);
