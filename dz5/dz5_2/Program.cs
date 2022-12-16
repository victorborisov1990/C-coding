// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. (индексы 1, 3 и тд)

void RandomArray(int[] array)//процедура по заполнению массива случайными числами
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-15, 21); // [-15, 20]
}

int SumOddIndex (int[] array)//суммирует элементы массива с нечетными индексами
{   
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
        sum+=array[i];
    return sum;
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
Console.WriteLine($"Сумма элементов массива с нечетными индексами = {SumOddIndex (array)}");//вывод количества четных чисел