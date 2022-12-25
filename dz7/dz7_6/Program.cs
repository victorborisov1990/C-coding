// заполнить матрицу (m х n символов) по диагонали
void InputDiagonalMatrix(int[,] matrix, int startValue)
{   
    int count = startValue;
    int actualRow = 0;
    int iStart = 0;
    int jStop = 0;
    int i = 0;
    while(count < matrix.GetLength(0)*matrix.GetLength(1)+startValue)//проходим алгоритм стролько раз, сколько элементов
    {
        i = iStart;
        for (int j = actualRow; j >=jStop; j--)
        {
            //Console.WriteLine($"i={i}, j= {j}, count = {count}, actualRow={actualRow}, iStart={iStart}, jstop = {jStop}");
            matrix[i,j]=count;
            i++;
            count++;
            
        }
        if(matrix.GetLength(0)==matrix.GetLength(1))//если матрица симметричная
        {
            if (actualRow < matrix.GetLength(1)-1)//если текущий стартовый столбец не равен крайнему правому
                actualRow++;//увеличить стартовый столбец для движения справа налево
            else //когда дошли до крайнего правого столбца, каждый проход - 
            {
                iStart++;//увеличиваем индекс стартовой строки
                jStop++;//и ограничиваем столбец слева
            }
        }  
        else if(matrix.GetLength(0) < matrix.GetLength(1))//если строк меньше, чем столбцов
        {
            if(i == matrix.GetLength(0))//каждый раз, когда доходим до последней строки, 
                jStop++;//ограничиваем столбец слева
            if (actualRow < matrix.GetLength(1)-1)//если текущий стартовый столбец не равен последнему
                actualRow++;//увеличить стартовый столбец для движения справа налево
            else //когда дошли до крайнего правого столбца, каждый проход - 
            {
                iStart++;//увеличиваем индекс стартовой строки 
            }
        }
        else//если строк больше, чем столбцов
        {
            if (actualRow < matrix.GetLength(1)-1)//если текущий стартовый столбец не равен крайнему правому
                actualRow++;//увеличить стартовый столбец для движения справа налево
            else //когда дошли до крайнего правого столбца
            {
                iStart++;//увеличиваем индекс стартовой строки
                if(i == matrix.GetLength(0))//каждый раз, когда доходим до последней строки, 
                    jStop++;//ограничиваем столбец слева
            }
            
        }
    }
    
}

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
Console.Write("Введите размер матрицы через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write("Введите начальное значение последовательности: ");
int number = int.Parse(Console.ReadLine());
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Массив:");
InputDiagonalMatrix(matrix, number);
PrintMatrix(matrix);

