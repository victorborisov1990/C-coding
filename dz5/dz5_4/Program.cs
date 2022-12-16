//Ввести  в строку числа проведения уроков. По четным числам Вася получал 4, по нечет - 3.
//Расположите четные и нечетные числа в разных строчках. Если 3 будет больше, в четеверти будет 3, иначе 4. 
Console.Clear();
string even = string.Empty;//строка под четные элементы
string odd = string.Empty;//строка под нечетные элементы
Console.WriteLine("Введите в строку через пробел числа, когда были уроки английского:");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();//перевод сроки в массив инт
foreach (int element in array)
{
    if(element%2 == 0)//если очередной элемент четный
        even+=Convert.ToString(element)+" ";//добавляем его в строку четных чисел
    else
        odd+=Convert.ToString(element)+" ";//иначе в строку нечетных
}
Console.WriteLine(even);//вывод строк
Console.WriteLine(odd);
if (odd.Length>even.Length)//если строка нечетных длинее (больше элементов)
    Console.WriteLine("Тройка в четверти");//то будет 3
else
    Console.WriteLine("Четверка в четверти"); //а если четных больше или равно, то 4