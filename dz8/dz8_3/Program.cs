// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц (поэлементное).
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

int[,] Umnogenie(int[,] matrix1, int[,] matrix2)//поэлементное умножение элементов массива
{   
    
    for (int i =0; i < matrix1.GetLength(0); i++)//перебор строк
        for (int j = 0; j < matrix1.GetLength(1); j++)//проход по столбцам
            {
                    matrix1[i, j] *= matrix2[i, j];// 
            }
    return matrix1;
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrixA = new int[size[0], size[1]];
int[,] matrixB = new int[size[0], size[1]];
Console.WriteLine("Первая матрица:");
InputMatrix(matrixA);
PrintMatrix(matrixA);
Console.WriteLine("Вторая матрица:");
InputMatrix(matrixB);
PrintMatrix(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintMatrix(Umnogenie(matrixA,matrixB));
