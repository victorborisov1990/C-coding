// Требуется написать программу, которая в качестве входных данных использует исходное бинарное черно-белое изображение (W or B)
//и полученный программой негатив (заведомо с ошибкой), и на основе этого определяет количество пикселей, в которых допущена ошибка.

void PrintMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void ErrorSearch(char[,] image, char[,] negImage)
{
    for (int i = 0; i < image.GetLength(0); i++)//создание негатива из изображения
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if(image[i, j] == 'W')
                image[i,j] = 'B';
            else image[i,j] = 'W';
        }   
    }
    PrintMatrix(image);
    Console.WriteLine();

    int count = 0;
    for (int i = 0; i < image.GetLength(0); i++)//сравнение сгенерированного негатива и негатива с ошибками
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if(image[i, j] != negImage[i,j])//если соответствующие символы отличаются, увелич счетчик
                count++;
        }   
    }
    Console.WriteLine($"Количество ошибок: {count}");    
}


char[,] pozitiv= {  {'W','B','B','W'},
                    {'B','B','B','B'},
                    {'B','B','B','B'},
                    {'W','B','B','W'} };

char[,] negativ= {  {'B','W','W','B'},
                    {'W','W','W','W'},
                    {'W','B','W','W'},
                    {'B','W','W','W'} };
Console.Clear();
Console.WriteLine("Позитив Миши:");
PrintMatrix(pozitiv);
Console.WriteLine();
Console.WriteLine("Негатив Миши с ошибками:");
PrintMatrix(negativ);
Console.WriteLine();
Console.WriteLine("Негатив из позитива:");
ErrorSearch(pozitiv,negativ);