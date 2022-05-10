/*Написать программу, которая из имеющегося массива строк 
сформирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатурвы, 
либо задать на старте выполнения алгоритка. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/
void PrintArray(string[] stringArray)               //Метод для печати массива
{
    for (int i = 0; i < stringArray.Length; i++)
        Console.Write(stringArray[i] + " ");
}
int FindElement(string[] stringArray)
{
    int count = 0;
    foreach (string s in stringArray)
    {
        if (s.Length <= 3) count++;
    }
    return count;
}

string[] firstArray = { "Раз", "Два", "Три", "Четыре", "Пять", "Я", "Иду", "Искать" };  //Наш массив строк
PrintArray(firstArray);
Console.WriteLine(FindElement(firstArray));