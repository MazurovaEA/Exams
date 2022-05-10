/*Написать программу, которая из имеющегося массива строк 
сформирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

void PrintArray(string[] stringArray)           //Метод для печати массива
{
    for (int i = 0; i < stringArray.Length; i++)
        Console.Write(stringArray[i] + " ");
}
int FindElements(string[] stringArray, int length)           // Функция поиска кол-ва элементов (<= 3). Необходима для определения размера нового массива
{
    int count = 0;
    foreach (string s in stringArray)
    {
        if (s.Length <= length) count++;
    }
    return count;
}
string[] NewArray(string[] stringArray, int count, int length, int i = 0)           // Функция создания нового массива с условием (<= 3) из существующего массива
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
int lengthString = 3;     //Длина искомых строк (по условию задачи равна 3)
int countElement = FindElements(firstArray, lengthString);         // Данная переменная определяет размер нового массива
PrintArray(firstArray);            // Вывод заданного массива в терминал
Console.WriteLine();
PrintArray(NewArray(firstArray, countElement, lengthString));         //Вывод искомого массива в терминал