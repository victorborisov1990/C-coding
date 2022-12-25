// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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
Console.Clear();
Console.Write("Введите размер матрицы через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.Write("Введите номер строки и столбца через пробел: ");
int[] coordinates = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (coordinates[0]>size[0]||coordinates[1]>size[1])
{
    Console.Write("Таких координат не существует, введите номер строки и столбца еще раз: ");
    coordinates = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
Console.WriteLine($"Элемент массива с координатами ({coordinates[0]}, {coordinates[1]}) = {matrix[coordinates[0]-1,coordinates[1]-1]}");