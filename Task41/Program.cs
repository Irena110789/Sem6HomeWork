// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

double InputM(double m)
{
double num = -1;
double count = 0;
for(double i = 1; i <= m; i++)
{
Console.WriteLine("Input " + i + " number :");
num = Convert.ToDouble(Console.ReadLine());
if(num > 0)
count++;
}return count;
}
Console.WriteLine("Input M");
double m = Convert.ToDouble(Console.ReadLine());
double result = InputM(m);
Console.WriteLine(result + " numbers greater than 0 ");