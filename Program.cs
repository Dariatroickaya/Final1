// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] array = new string[4] {"1234", "1567", "-2", "computer science"};
string[] arraynew = new string[array.Length];


void NewStringArray(string[] array, string[] arraynew)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        arraynew[index] = array[i];
        index++;
        }
    }
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


NewStringArray(array,arraynew);
PrintArray(arraynew);