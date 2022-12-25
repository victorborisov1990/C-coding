//Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11); // [0, 10]
    }
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void TransponMatrix(int[,] matrix)
{
    int tmp = -1;
    for (int i = 0; i < matrix.GetLength(0)/2; i++)//проходим половину строк. в случае нечетного числа, средняя строка не меняется
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                tmp = matrix [i, j];
                matrix[i, j] = matrix[matrix.GetLength(0)-1-i, j];
                matrix[matrix.GetLength(0)-1-i, j] = tmp;
            }
            
    }
}

Console.Clear();
Console.Write("Введите размер матрицы через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Исходный массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("После транспонирования:");
TransponMatrix(matrix);
PrintMatrix(matrix);
