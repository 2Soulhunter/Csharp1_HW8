/*                          Домашнее задание к семинару 8 С#
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2                                 */

int row = new Random().Next(3, 6);      // Генерируем кол-во строк в заданном диапазоне
int column = new Random().Next(3, 6);   // Генерируем кол-во столбцов в заданном диапазоне
int[,] Array = new int[row, column];    // Создаём пустой массив
FillArray(Array);                       // Запускаем функцию заполнения массива
Console.WriteLine("Неотсортированный массив:");
PrintArray(Array);                      // Выводим изначальный массив на экран
SortArrayRows(Array);                   // Запускаем функцию построчной сортировки массива
Console.WriteLine("Массив отсортирован:");
PrintArray(Array);                      // Выводим на экран отсортированный массив


void FillArray(int[,] Array)            // Функция заполнения массива случайными числами
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(1, 99);  // в заданном диапазоне
        }
    }
}

void PrintArray(int[,] Array)            // Функция вывода массива на экран
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j],2}\t");
        }
        Console.Write(Environment.NewLine + Environment.NewLine);
    }
}

void SortArrayRows(int[,] Array)        // Функция построчной сортировки массива
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int k = 0; k < Array.GetLength(1) - 1; k++)
            {
                if (Array[i, k] < Array[i, k + 1])
                {
                    int temp = Array[i, k];
                    Array[i, k] = Array[i, k + 1];
                    Array[i, k + 1] = temp;
                }

            }
        }
    }
}