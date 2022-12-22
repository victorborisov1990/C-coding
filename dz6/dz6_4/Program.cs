// Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки символов данной строки.

void CombinationsFromStrig(string incomingStr, string stringToPrint = "")//по умолчанию строка на печать пустая
{
    if (incomingStr.Length == 1) //если длина входящей строки = 1, то это последний символ,
    {
        Console.WriteLine(stringToPrint+incomingStr);//добавить его к "строке на печать" и вывести на экран
        return;//выход из процедуры
    }

    string alphabet = string.Empty;
    foreach (char element in incomingStr) //создание алфавита уникальных символов из входящей строки
    {
        if (alphabet.Contains(Char.ToString(element))==false)//если в алфавите не присутствует текущий элемент строки, 
        alphabet+=element;//то добавить его в алфавит
    }
    
    if (alphabet.Length == 1)//если алфавит содержит 1 символ, а длина входящей строки больше 1, то ветвлений больше не будет, 
    {
        Console.WriteLine(stringToPrint+incomingStr);//добавить "вх строку" к "строке на печать" и вывести на экран
        return;//выход из процедуры
    }

        foreach(char symbol in alphabet)//для каждого уникального элемента из входящей строки
    {
        string strWithoutSymbol = incomingStr.Remove(incomingStr.IndexOf(symbol), 1); //Создать новую строку без текущего уник элемента
        string newStr = stringToPrint + Char.ToString(symbol); //добавить к строке на печать новый элемент последовательности
        CombinationsFromStrig(strWithoutSymbol, newStr);//передать на следующий уровень строку без текущего символа и начало комбинации
    }
}

Console.Clear();
Console.Write("Введите полседовательность символов: ");
string? symbols = Console.ReadLine();

CombinationsFromStrig(symbols);
