//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Введите число, которое нужно возвести в степень: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int stepen = int.Parse(Console.ReadLine());
int result = number;
int step_show = stepen;//для красивого вывода
while (stepen < 0) //если введена отрицательная степень, вводим, пока не введут положительную
    {
        Console.Write("Введите степень больше 0: ");
        stepen = int.Parse(Console.ReadLine());   
    }
while (stepen!=1)//таким образом, если степень 1, то умножения не будет, иначе возводить будет нужное количество раз
{
    result=result*number;
    stepen--;
}
Console.WriteLine($"{number}^{step_show} = {result}");