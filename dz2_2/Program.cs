//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number < 100)
     Console.Write("Нет 3й цифры");   
else 
    {
    while (number > 999) //пока в числе больше 3 цифр, будем делить его на 10
         number = number / 10;   
    Console.WriteLine($"Третья цифра числа: {number%10}");//вывод 3 цифры в оставшимся 3значном числе
    }