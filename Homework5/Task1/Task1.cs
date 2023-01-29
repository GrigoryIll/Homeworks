/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] CreateArray(int dimension)
{
    int[] array = new int [dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetEvenNum(int[] array)
{
    int even = 0;

    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i] % 2 == 0)
            even += +1;
    }
    return even;
}

int[] array = CreateArray(4);
PrintArray(array);
int even = GetEvenNum(array);
Console.WriteLine($"Количество четных чисел в массиве: {even}.");