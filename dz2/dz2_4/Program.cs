﻿/*вводить последовательно числа, пока не будет введен 0. Требуется определить значение второго по величине элемента
 в этой последовательности, то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.  
*/
Console.Clear();
Console.Write("Введите числа, ввод 0 окончит ввод: \n");
int number = int.Parse(Console.ReadLine());//Ввод первого числа
int max1 = number;//максимум - по умолчанию это первое введенное число
int max2 = 0;//второй максимум - по умолчанию это 0
while (number != 0) //пока не введен 0
    {
        number = int.Parse(Console.ReadLine());//ввод очередного числа
        if (number>max1)//Если очередное число больше максимального - 
            {
                max2=max1;// - максимум становиться втормым максимумом,
                max1=number;// а текущее число становится новым максимумом
            }
        else if (number < max1 && number > max2)//Если очередное число меньше максимального, но больше второго максимума -(условие number < max1 можно убрать!)
            max2 = number; //- текущее число становится втормым максимумом
    }
Console.Write($"Второй максимум: {max2}");
