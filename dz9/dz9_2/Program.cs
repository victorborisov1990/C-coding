// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

int Akkerman (int m, int n)
{
    if(m == 0)
        return n+1;
    if(n == 0)
        return Akkerman(m-1,1);
    return Akkerman(m-1, Akkerman(m, n-1));
}

Console.Clear();
Console.WriteLine("Необходимо ввести аргументы функции Аккермана");
Console.Write("Введите аргумент m: ");
int m = Convert.ToInt32(Console.ReadLine());
while(m < 0)
{
    Console.Write("Число не должно быть отрицательным. Введите аргумент m: ");
    m = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите аргумент n: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 0)
{
    Console.Write("Число не должно быть отрицательным. Введите аргумент n: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(Akkerman(m,n));
