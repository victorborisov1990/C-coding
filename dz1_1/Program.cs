/*Напишите программу, которая принимает на вход 2 числа 
и выдает какое большее, а какое меньшее*/
Console.Clear();
Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine());
if (number_1 > number_2) 
    Console.WriteLine($"Число {number_1} больше числа {number_2}");
else if (number_1 < number_2)
    Console.WriteLine($"Число {number_1} меньше числа {number_2}");
else
    Console.WriteLine($"Числа {number_1} и {number_2} равны");

