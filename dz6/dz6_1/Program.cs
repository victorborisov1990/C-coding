// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
int count = 0;
Console.WriteLine("Введите в строку через пробел числа:");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();//перевод сроки в массив инт
foreach (int element in array)
    if(element > 0)//если очередной элемент больше 0
        count++;//то увеличиваем счетчик
Console.WriteLine($"Чисел больше 0: {count}"); //вывод
