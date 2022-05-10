/*Написать программу, которая из имеющегося массива строк 
сформирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатурвы, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

void PrintArray(string[] stringArray)           //Метод для печати массива
{
    for (int i = 0; i < stringArray.Length; i++)
        Console.Write(stringArray[i] + " ");
}
int FindElement(string[] stringArray, int length = 3)           // Функция поиска кол-ва элементов (<= 3). Необходима для определения размера нового массива
{
    int count = 0;
    foreach (string s in stringArray)
    {
        if (s.Length <= length) count++;
    }
    return count;
}

string[] NewArray(string[] stringArray, int count, int i = 0)           // Функция создания нового массива с условием (<= 3) из существующего массива
{
    string[] newStringArray = new string[count];
    foreach (string s in stringArray)
    {
        if (s.Length <= 3)
        {
            newStringArray[i] = s;
            i++;
        }
    }
    return newStringArray;
}

string[] firstArray = { "Раз", "Два", "Три", "Четыре", "Пять", "Я", "Иду", "Искать" };          // Заданный массив строк
int countElement = FindElement(firstArray);         // Данная переменная определяет размер нового массива
PrintArray (firstArray);            // Вывод заданного массива в терминал
Console.WriteLine();
PrintArray(NewArray(firstArray, countElement));         //Вывод искомого массива в терминал