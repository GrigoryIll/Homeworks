/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

double [] CreateArray(int dimension)
{
    double [] array = new double [dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-10, 10) + rnd.NextDouble();
    }
    return array;
}

void PrintArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double GetDiff(double[] array)
{
    double dif = array.Max() - array.Min();
    return dif;
} 

double[] array = CreateArray(4);
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным числом в массиве: {GetDiff(array)}.");