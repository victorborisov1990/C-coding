﻿//Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) 
//на |K| элементов вправо, если K – положительное и влево, если отрицательное.

Console.Clear();
int temp = 0;
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());//Ввод числа
int [] array = new int[size]; //Создаем пустой массив с элементами типа Инт, длиной {size} элементов
for (int i = 0; i<array.Length; i++)
{
    Console.Write($"Введите {i+1} число: ");
    array[i]=int.Parse(Console.ReadLine());//заполняем текущий элемент массива введенным в консоль числом
}
Console.WriteLine($"[{string.Join(", ",array)}]");//вывод массива
Console.WriteLine("Введите коэффициент сдвига ('+'-вправо, '-'-влево): ");
int sdvig = int.Parse(Console.ReadLine());//Ввод коэффициента сдвига

if (sdvig>0)
    for (int j = sdvig; j > 0; j--)//цикл сколько раз сдвигать вправо весь массив на 1 символ
    {
        temp = array [array.Length-1];//сохраняем последний элемент массива, который выдавит при сдвиге
        for (int i = array.Length-1; i > 0; i--)//начиная с последнего элемента и до 1го.
            array[i]=array[i-1];//заменить текущий элемент тем, что слева
        array[0]=temp;//заменяем 0й элемент тем, что выдавило при сдвиге
    }
else if(sdvig<0)
    for (int j = sdvig; j < 0; j++)//цикл сколько раз сдвигать влево весь массив на 1 символ
    {
        temp = array [0];//сохраняем 0й элемент массива, который выдавит при сдвиге
        for (int i = 0; i < array.Length-1; i++)//начиная с 0го элемента и до предпоследнего.
            array[i]=array[i+1];//заменить текущий элемент тем, что справа
        array[array.Length-1]=temp;//заменяем последний элемент тем, что выдавило при сдвиге
    }    

Console.WriteLine($"[{string.Join(", ",array)}]");//вывод массива