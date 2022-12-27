// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

void InputMatrix(int[,] matrix)//Заполнение массива случайными числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11); // [0, 10]
    }
}

void PrintMatrix(int[,] matrix)//вывод массива на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

int MinSum(int[,] matrix)//поиск  строки с минимальной суммой элементов
{   
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
            sum+=matrix[0,j];//вычисление суммы элементов в 0й строке
    int minSum  = sum;
    int minSumIndex = 0;
    for (int i =1; i < matrix.GetLength(0); i++)//перебор остальных строк
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)//проход по столбцам
            sum+=matrix[i,j];//вычисление суммы элементов в строке
        if(sum < minSum)
        {
            minSum=sum;
            minSumIndex=i;
        }
        //Console.WriteLine($"sum= {sum}, minSum={minSum} minSumIndex={minSumIndex}"); 
    }
    return minSumIndex;
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0]==size[1])
    {
        Console.Write("Матрица не должна быть симметричной.Введите размер матрицы: ");
        size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    }
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
int result = MinSum(matrix)+1;//нумерация строк с 1
Console.WriteLine($"Строка с минимальной суммой: {result}");