//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateArray()
{
    int [] array = new int [8];
    Random number = new Random();
    for (int i = 0; i < 8; i++)
    {
        array[i] = number.Next();
    }
    return array;
}
int [] a = CreateArray();

void PrintArray (int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($" {array[i]} ");
    }
}
PrintArray(a);