/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

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
int number = GetNumber("Введите число");

if (number > 0)
{
    string str = number.ToString();
    {
        int sum = 0;

        for(int i = 0; i < str.Length; i ++)
        {
            string str2 = Convert.ToString(str[i]);
            sum = sum + int.Parse(str2);
        }
        Console.WriteLine($"Сумма цифр в числе составляет: {sum}");
    
    }
}
if (number < 0)
{
    string str = number.ToString();
    {
        int sum = 0;

        for(int i = 1; i < str.Length; i = i + 1)
        {
            string str2 = Convert.ToString(str[i]);
            sum = sum + int.Parse(str2);
        }
        Console.WriteLine($"Сумма цифр в числе составляет: {sum}");
    
    }
}