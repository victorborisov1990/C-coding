// Сформируйте 3 мерный массив из неповторяющихся 2значных чисел. 
//( те значения должны быть в диапазоне 10-99, произведение размеров измерений должно быть не более 90) 
//начальное значение 10, инкремент на каждый элемент


Console.Clear();
Console.Write("Введите размер матрицы с 3 измерениями: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// size[0] - row
// size[1] - column
// size[2] - depth
while (size[0]*size[1]*size[2] > 90)
    {
        Console.Write("Слишком большой размер.Введите размер матрицы: ");
        size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    }
int[,,] matrix = new int[size[0], size[1], size[2]];
int count = 10;
for (int i = 0;i < size[0]; i++)
    for(int j = 0; j < size[1]; j++)
        for(int k = 0; k < size[2]; k++)
            {
                matrix[i,j,k] = count;
                count++;
                Console.WriteLine($"({i},{j},{k}) = {matrix[i,j,k]}");
            }

