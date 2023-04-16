/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();
Console.Write("Введите координаты точек k1, b1, k2, b2: ");

string[] num = Console.ReadLine().Split(" ");
double k1 = int.Parse(num[0]);
double b1 = int.Parse(num[1]);
double k2 = int.Parse(num[2]);
double b2 = int.Parse(num[3]);


double x = ((b1 - b2) / (k1 - k2)) * -1;
double y = k2 * x + b2;
Console.WriteLine($"Точка перечечения прямых y={k1}*x+{b1} и y={k2}*x+{b2} равна ({x:f1}; {y:f1})");


