//Напишите программу, которая принимает на вход число 1-7 и пишет, соответствует ли цифра выходному дню
Console.Clear();
Console.Write("Введите число, соответствующее дню недели: ");
int number = int.Parse(Console.ReadLine());
while (number < 1 || number > 7) //если введено число не в диапазоне 1-7, продолжаем ввод
    {
    Console.Clear();
    Console.Write("Введите число от 1 до 7: ");
    number = int.Parse(Console.ReadLine());   
    }
if (number == 6 || number == 7)
    Console.WriteLine($"{number} -> ДА");//если 6 или 7 - ДА (выходной)
else
    Console.WriteLine($"{number} -> НЕТ");//иначе - нет(будний)   
