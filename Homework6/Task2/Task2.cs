/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

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

double getX(double b1, double b2, double k1, double k2)
{
    double resultX = (b1 - b2) / (k2 - k1);
    return resultX; 
}

double getY(double k1, double pointX, double b1)
{
    double resultY = k1 * pointX + b1;
    return resultY; 
}

double b1 = GetNumber("Введите b1");
double k1 = GetNumber("Введите k1");
double b2 = GetNumber("Введите b2");
double k2 = GetNumber("Введите k2");

double pointX = getX(b1, b2, k1, k2);
double pointY = getY(k1, pointX, b1);

Console.WriteLine($"Точка пересечения двух прямых: {pointX}, {pointY}");