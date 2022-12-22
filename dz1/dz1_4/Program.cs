/*Напишите программу, которая принимает на вход число N
и выводит в консоль все четные числа от 1 до N*/
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
for (int i = 2; i <= number; i+=2)
    Console.Write($"{i} ");