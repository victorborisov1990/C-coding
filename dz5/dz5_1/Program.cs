// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void RandomArray(int[] array)//процедура по заполнению массива случайными числами
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); // [100, 999]
}

int EvenCount (int[] array)// функция возвращает количество четных элементов
{   
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i]%2==0)//если текущий элемент массива делится без остатка на 2
            count++;//то увеличиваем счетчик на 1
    return count;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());//Ввод числа
while (size < 1 || size >100) //если введен слишком большой или слишком маленький размер массива
    {
    Console.Clear();
    Console.Write("Введите размер массива: ");
    size = int.Parse(Console.ReadLine());
    }  
int [] array = new int[size]; //Создаем пустой массив с элементами типа Инт, длиной {size} элементов
RandomArray(array);//заполняем массив случайными числами
Console.WriteLine($"[{string.Join(", ",array)}]");//вывод массива
Console.WriteLine($"Количество четных элементов массива = {EvenCount (array)}");//вывод количества четных чисел