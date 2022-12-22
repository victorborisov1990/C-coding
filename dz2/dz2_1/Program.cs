//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
while (number < 100 || number > 999) //если введено не трехзначное, вводим до тех пор, пока не введено подходящее
    {
    Console.Clear();
    Console.Write("Введено не трехзначное число, ведите трехзначное: ");
    number = int.Parse(Console.ReadLine());   
    }
Console.WriteLine($" вторая цифра: {(number/10)%10}");//вывод 2 цифры

