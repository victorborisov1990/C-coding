// Задайте начальное значение n и конечное m. вывести на экран сумму чисел от n до m. Через рекурсию

int Sum (int start, int end)
{
    if(start==end)
        return end;
    return Sum(start+1,end)+start;
}

Console.Clear();
Console.Write("Введите начальное значение последовательности: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение последовательности: ");
int m = Convert.ToInt32(Console.ReadLine());
while (n>=m)
{
    Console.Write("Введите начальное значение последовательности: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечное значение последовательности: ");
    m = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(Sum(n,m));

