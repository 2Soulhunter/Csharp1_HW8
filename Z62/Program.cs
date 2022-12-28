/*                          Домашнее задание к семинару 8 С#
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07                     */

int size = 4;
int[,] array = new int[size, size];
int count = 1;
int i = 0;
int j = 0;
FillArray(array);
PrintArray(array);


void FillArray(int[,] array)
{
    while (count <= size * size)
    {
        array[i, j] = count;
        if (i <= j + 1 && i + j < size - 1)
            ++j;
        else if (i < j && i + j >= size - 1)
            ++i;
        else if (i >= j && i + j > size - 1)
            --j;
        else
            --i;
        ++count;
    }
}

void PrintArray(int[,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            Console.Write($" {array[x, y],2} ");
        }
        Console.WriteLine();
    }
}