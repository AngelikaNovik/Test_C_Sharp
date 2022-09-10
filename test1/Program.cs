// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна три символа. 

string[] array1 = new string[5] { "hello", "world", "Russia", "777", "888" };
string[] array2 = new string[array1.Length];
void FillArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i< array1.Length; i++)
    {
        if(array1[i].Length<=3)
        {
            array2[count]=array1[i];
        }
    }
}

