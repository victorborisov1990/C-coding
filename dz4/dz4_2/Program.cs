// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();//получаем число как строку
double sum = 0;
for (int i = 0; i < number.Length; i++)//перебираем сроку посимвольно
    sum+=Char.GetNumericValue(number[i]);//каждый символ преобразуем в число и прибавляем к сумме
Console.WriteLine($"Сумма = {sum}");
