// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FoundPodouble(double k1, double b1, double k2, double b2)
{
    if(k1 == k2)
     Console.WriteLine("Lines are paralell." );
    else
    {     
    double x = ((b2 - b1) / (k1 - k2));
    double y = k2 * x + b2;
    Console.WriteLine("The intersection point of the lines has the following coordinates: ");
    Console.Write("x   " + x);
    Console.Write(" y   " + y);
    }
}
Console.WriteLine("y = k1 * x + b1  ");
Console.Write("Input k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("y = k2 * x + b2  ");
Console.Write("Input k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());
FoundPodouble(k1, b1, k2, b2);