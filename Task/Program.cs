// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] StringArray(string[] arr)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       string element = arr[i];
       if (element.Length <= 3) size++; 
    }
    string[] newarr = new string[size];
    for (int i = 0, j = 0; i < arr.Length; i++)
    {
        string element = arr[i];
        if(element.Length <= 3)
        {
            newarr[j] = element; j++;
        }
    }
    return newarr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

string[] array = new string[] { "Hello", "2", "World", ":-)" };
// string[] array = new string[] { "1234", "1567", "-2", "computer science" };
//string[] array = new string[] { "Russia", "Denmark", "Kazan" };

PrintArray(array);
string[] stringArray = StringArray(array);
Console.Write("   ->   ");
PrintArray(stringArray);
