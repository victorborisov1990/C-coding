// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
double min = new double();
double max = new double();

void RandomDoubleArray(double[] arr)//процедура по заполнению массива случайными вещественными числами
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = Math.Round(new Random().NextDouble()*10,2); //случайные числа (0,0 до 1,0)*10, те от 0,0 до 10,0. 2 знака после запятой
}
void MinAndMax (double[] arr)//процедура по вычислению минимального и максимального
{
    for (int i = 1; i < arr.Length; i++)
        if (arr[i]>max)
            max=arr[i];
        else if (arr[i]<min)
            min=arr[i];
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
double [] array = new double[size]; //Создаем пустой массив с элементами типа Инт, длиной {size} элементов
RandomDoubleArray(array);//заполняем массив случайными числами
min = array[0];
max = array[0];
Console.WriteLine($"[{string.Join(", ",array)}]");//вывод массив
MinAndMax(array);
Console.WriteLine($"Минимальный элемент массива = {min}, максимальный элемент массива = {max}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {Math.Round(max - min, 2)}");