/*Напишите программу, которая принимает на вход координаты 2 точек
в 3-мерном пространстве (X,Y,Z) и выдает расстояние между ними*/

Console.Clear();
Console.Write("Введите X1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y1: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z1: ");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X2: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y2: ");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z2: ");
double Z2 = Convert.ToDouble(Console.ReadLine());
double length = Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2)+Math.Pow(Z2-Z1,2));
Console.WriteLine($"Расстояние = {length}");
