// Напишите программу, которая заполнит спирально массив 4 на 4.
//Сделал универсальный вариант, на разные размерности массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// size[0] - row
// size[1] - column

int[,] matrix = new int[size[0], size[1]];
int count = 1;
int upi = 0, downi = matrix.GetLength(0)-1;
int leftj = 0, rightj = matrix.GetLength(1)-1;

while(count < matrix.GetLength(0)*matrix.GetLength(1)+1)
{
    for (int j = leftj; j <= rightj; j++)//двигаемся слева направо
    {
        matrix[upi,j] = count;
        count++;
    }
    upi++;//опускаем верхнюю границу
    for(int i = upi; i <= downi; i++)//двигаемся сверху вниз
    {
        matrix[i,rightj] = count;
        count++;
    }
    rightj--;//сдвигаем влево правую границу
    for (int j = rightj ; j >= leftj; j--)//двигаемся справа налево
    {
        matrix[downi,j] = count;
        count++;
    }
    downi--;//поднимаем нижнюю границу
    for(int i = downi; i >= upi; i--)//двигаемся снизу вверх
    {
        matrix[i, leftj] = count;
        count++;
    }
    leftj++;//сдвигаем влево правую границу
}
Console.WriteLine();
PrintMatrix(matrix);