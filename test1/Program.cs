﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна три символа. 

string[] array1 = new string[5] { "hello", "world", "Russia", "77", "888" };
string[] array2 = new string[array1.Length];
void FillArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
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
FillArray(array1, array2);
PrintArray(array2);

