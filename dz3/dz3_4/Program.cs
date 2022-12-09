/*Найти, какое макс число ягод можно собрать за 1 подход с 3 соседних кустов
(сумма a[i],a[i+1] и a[i+2]) */

Console.Clear();
Console.Write("Введите количество кустов: ");
int number = int.Parse(Console.ReadLine());
while (number < 3 || number > 1000) //если введено число меньше 3, продолжаем ввод до ввода нужного числа
    {
    Console.Clear();
    Console.Write("Введите количество кустов (не меньше 3 и не более 1000): ");
    number = int.Parse(Console.ReadLine());   
    }
 
Random rand = new Random();
int [] kust = new int[number]; //создаем пустой массив размером в количество кустов
for (int i=0; i<kust.Length; i++) 
{
    kust[i]=rand.Next(100,500); //заполняем массив случайными числами от 1 до 15 
    Console.WriteLine($"Урожайность куста {i+1}: {kust[i]} ягод"); //выводим массив 
}
Console.WriteLine("");
int max = kust[0]+kust[1]+kust[2]; //по умолчанию максимум это сумма первых 3х элементов
Console.WriteLine($"Урожайность кустов 1, 2 и 3 = {max} ягод");

int SumOf3 (int num1, int num2, int num3, int maximum)//функция, принимает на вход 3 числа и текущ максимум
{
    int sum = num1 + num2 + num3;
    if (sum>maximum)//если их сумма больше, то это новый максимум
        maximum = sum;
    return maximum;
}

for (int i = 1; i < kust.Length-2; i++)//проверка основной массы кустов, не включая 2х в конце, у которых соседи в начале массива
{
    max = SumOf3(kust[i],kust[i+1],kust[i+2],max);
    Console.WriteLine($"Урожайность кустов {i+1}, {i+2} и {i+3}. Максимальная урожайность: {max} ягод");
}
if(kust.Length > 3)//Если количество кустов = 3, то выполнять действия нет смысла. Иначе:
{
    max = SumOf3(kust[kust.Length-2],kust[kust.Length-1],kust[0],max);//проверка 2 кустов в конце массива и одного в начале
    Console.WriteLine($"Урожайность кустов {kust.Length-1}, {kust.Length} и 1. Максимальная урожайность: {max} ягод");
}
if(kust.Length > 4)//Если количество кустов = 4, то выполнять действия нет смысла. Иначе:
{
    max = SumOf3(kust[kust.Length-2],kust[0],kust[1],max);//проверка 1 куста в конце массива и двух первых
    Console.WriteLine($"Урожайность кустов {kust.Length}, 1 и 2. Максимальная урожайность: {max} ягод");
}
