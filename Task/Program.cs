/*
    Задача: Написать программу, которая из имеющегося массива строк формирует 
    новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный 
    массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
    При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно 
    массивами.
    Примеры:
    [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
    [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
    [“Russia”, “Denmark”, “Kazan”] → []
*/

Console.Write("Введите количество элементов  массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы массива (слова, числа, символы): ");

string[] array = GetArray(lengthArray); 
int newLenght = GetLengthArray(array);
string[] newArray = SortArray(array);

PrintArray(array);
PrintArray(newArray);

string[] GetArray(int length)
{
    string[] array = new string[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

int GetLengthArray(string[] array)
{
    int length = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 3) continue;
        else length++;
    }
    return length;
} 

string[] SortArray(string[] array)
{
    string[] newArray = new string[newLenght];
    int index = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 3) continue;
        else newArray[index] = array[i];
        index++;
    }
    return newArray;
} 

void PrintArray(string[] array)
{
        Console.Write("[ ");
    
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"'{array[i]}' ");
        else Console.Write($"'{array[i]}', ");
    }
    
    Console.WriteLine("]");
  
}

