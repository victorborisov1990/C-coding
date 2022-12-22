/*Напишите программу, которая принимает на вход 3 числа 
и выдает максимальное из них*/
Console.Clear();
Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number_3 = int.Parse(Console.ReadLine());
int max = number_1;
if (number_2 > max) 
    max = number_2;
if (number_3 > max)
    max = number_3;
Console.WriteLine($"Максимальное число = {max}");

