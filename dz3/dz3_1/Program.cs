//Напишите программу, которая принимает на вход пятизначное число и проверяет, явлеяется ли оно полиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
while (number < 10000 || number > 99999) //если введено не пятизначное, вводим до тех пор, пока не будет введено подходящее
    {
    Console.Clear();
    Console.Write("Ошибка.\nВведите пятизначное число: ");
    number = int.Parse(Console.ReadLine());   
    }
string number_str = number.ToString();//число в строку
string reverse_srt = new string(number_str.Reverse().ToArray());//инверсия строки
if (number_str == reverse_srt)
    Console.WriteLine($"Число {number_str} - полиндром.");//если прямая и инверсная строки равны
else
    Console.WriteLine($"Число {number_str} - не полиндром,\nпотому что в обратном порядке: {reverse_srt}");//если не равны