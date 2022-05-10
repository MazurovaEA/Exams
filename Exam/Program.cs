/*Написать программу, которая из имеющегося массива строк 
сформирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

// Печать массива
void PrintArray(string[] stringArray)           
{
    for (int i = 0; i < stringArray.Length; i++)
        Console.Write(stringArray[i] + " ");
}

// Поиск кол-ва элементов, размер которых больше или равных 3 символам.
int FindElements(string[] stringArray, int length)           
{
    int count = 0;
    foreach (string s in stringArray)
    {
        if (s.Length <= length) count++;
    }
    return count;
}

// Создание нового массива из элементов заданного массива, длина которых меньше или равна 3 символам. 
string[] NewArray(string[] stringArray, int count, int length, int i = 0)           
{
    string[] newStringArray = new string[count];
    foreach (string s in stringArray)
    {
        if (s.Length <= length)
        {
            newStringArray[i] = s;
            i++;
        }
    }
    return newStringArray;
}

string[] firstArray = { "Раз", "Два", "Три", "Четыре", "Пять", "Я", "Иду", "Искать", ":-)" };          // Заданный массив строк
int lengthString = 3;     //Длина искомых строк (по условию задачи равна 3 символам)
int countElement = FindElements(firstArray, lengthString);         // Переменная для определения размера нового массива
Console.WriteLine("Изначально заданный массив: ");
PrintArray(firstArray);
Console.WriteLine();
Console.WriteLine($"Массив, сформированный из строк имеющегося массива, длина которых меньше либо равна {lengthString} символа: ");
PrintArray(NewArray(firstArray, countElement, lengthString));