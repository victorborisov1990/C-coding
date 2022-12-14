/*ребуется написать программу, производящую согласно утверждению Гольдбаха, разложение заданного чётного числа. 
Из всех пар простых чисел, сумма которых равна заданному числу, требуется найти пару, содержащую наименьшее простое число. 
Первым выводится наименьшее число.*/
Console.Clear();

bool IsPrime (int number)//проверка простое ли число (делится только на 1 и само себя)
{
    if (number == 1)//не является ни простым, ни составным числом, так как у него только один делитель
        return false;
    if (number ==2)//Число 2 — первое наименьшее простое, единственное четное, простое число
        return true;
    for (int i = 2; i < number; i++)//Проверяем число больше 2. делитель в диапазоне [2 - на один меньше проверяемого числа]
        if (number%i==0)//если число делится без остатка на любой делитель в диапазоне, то оно не простое
            return false;//возвращаем ложь
    return true; //Если предыдущие условия не сработали, значит число простое
}

int slog1=0, slog2=0;
Console.Write("Введите четное число больше 2: ");
int number = int.Parse(Console.ReadLine());

while (number < 4 || number%2 == 1) //если введено не четное число или меньше 4, вводим до тех пор, пока не будет введено подходящее
    {
    Console.Clear();
    Console.Write("Введите четное число больше 2: ");
    number = int.Parse(Console.ReadLine());
    }  

for (slog1 = 1;slog1 < number; slog1++)//одно из слогаемых будет точно меньше половины числа, поэтому нет смысла проходить весь диапазон   
    {
        slog2=number-slog1;//вычисляем второе слогаемое
        if(IsPrime(slog1)==true && IsPrime(slog2)==true)//если оба слогаемых простые числа
            {
                Console.WriteLine($"{number} = {slog1} + {slog2}");//то при первом нахождении такой пары выводим на экран
                break;//и выходим из цикла. При этом первое слогаемое будет наименьшим
            }
            
    }
