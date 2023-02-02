/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */


Console.WriteLine("Введите числа через пробел");
String str = Console.ReadLine();
String[] nums = str.Split(' ');
{
    int positive = 0;
    foreach (String i in nums)
    {
    if (int.Parse(i) > 0)
    positive += 1;
    }
    Console.WriteLine($"Количество положительных чисел: {positive}");
}
