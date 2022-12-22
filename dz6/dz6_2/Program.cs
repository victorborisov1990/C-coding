// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
Console.Write("Введите коэффициент К первой прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите константу первой прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент К второй прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите константу второй прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Уравнение первой прямой: Y = {k1}X + {b1}");
Console.WriteLine($"Уравнение второй прямой: Y = {k2}X + {b2}");

double x = Math.Round((b2-b1)/(k1-k2),2);
double y = k1*x+b1;
Console.WriteLine($"Точка пересечения 2х прямых с координатами: ({x}; {y})");
