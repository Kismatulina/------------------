// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World! 2, :-)");
﻿// Задача:
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

Console.WriteLine("Задайте рамер массива");
int a = int.Parse(Console.ReadLine());

int[] array1 = ArrayRandom(a);
Console.WriteLine("Основной массив:");
PrintArray(array1);

string array2 = NewLittleArray(array1);
Console.WriteLine("Обрезанный массив:");
Console.WriteLine($"[{string.Join(", ", array2)}]");

string NewLittleArray(int[] array)
{
    int[] newArray = array1;
    string result = string.Empty;
    for (int i = 0; i < newArray.Length; i++)
    {
        if(i < 3)
        {
            result += $"{newArray[i]}, ";
        }
    }
    return result;
}

int[] ArrayRandom(int a)
{
    int[] array = new int[a];
    Random random = new Random();
    for (int i = 0; i < a; i++)
    {
        array[i] = random.Next(-1000, 1000);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}