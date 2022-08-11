/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Даны функции: y = k1 * x + b1    и    y = k2 * x + b2");
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x, y;

void intersection(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
    else if (k1 == k2) Console.WriteLine("Прямые параллельны (не пересекаются)");
    else
        {
            x = (b2 - b1) / (k1 - k2);
            y = k1 * x + b1;
            Console.WriteLine($"Точка пересечения прямых: {x}, {y}");
        }
}

intersection(k1, b1, k2, b2);