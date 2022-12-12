//Напишите программу, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы. 
//После записи элементов в массив, необходимо его вывести на экран.

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());//Ввод числа
int [] array = new int[size]; //Создаем пустой массив с элементами типа Инт, длиной {size} элементов
for (int i = 0; i<array.Length; i++)
{
    Console.Write($"Введите {i+1} число: ");
    array[i]=int.Parse(Console.ReadLine());//заполняем текущий элемент массива введенным в консоль числом
}
Console.WriteLine($"[{string.Join(", ",array)}]");//вывод массива