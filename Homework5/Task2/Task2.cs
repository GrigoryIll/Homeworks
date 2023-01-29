/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

int[] CreateArray(int dimension)
{
    int[] array = new int [dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-100, 100);
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
int GetSumm(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++ )
    {
        if (i % 2 == 0)
            sum += + array[i];
    }
    return sum;
}

int[] array = CreateArray(4);
PrintArray(array);
int sum = GetSumm(array);
Console.WriteLine($"Сумма чисел на нечетных позициях в массиве: {sum}.");