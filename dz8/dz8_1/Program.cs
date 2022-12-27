// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 1 4 7 2 -> 7 4 2 1

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

int[,] SortString(int[,] matrix)//сортировка строк массива
{   
    
    for (int i =0; i<matrix.GetLength(0); i++)//перебор строк
    {
        int end = matrix.GetLength(1) - 1;//последний индекс в цикле столбцов
        for (int prohod = 1; prohod < matrix.GetLength(1); prohod++)//количество проходов сортировки
        {
            for (int j = 0; j < end; j++)//проход по столбцам
            {
                if(matrix[i,j]<matrix[i,j+1])//если текущий элемент меньше следующего
                {
                    int tmp = matrix[i, j];//поменять их местами
                    matrix[i, j] = matrix[i, j+1];
                    matrix[i, j+1] = tmp;
                }    
            }
            end--;//следующий проход по столбцам будет на 1 короче
        }
    }
    return matrix;
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
PrintMatrix(SortString(matrix));