/*                          Домашнее задание к семинару 8 С#
Задача 56: Задайте прямоугольный двумерный массив. Напишите 
программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка          */

int arrayRows = new Random().Next(3, 5);      // Генерируем кол-во строк в заданном диапазоне
int arrayColumns = new Random().Next(3, 9);   // Генерируем кол-во столбцов в заданном диапазоне
Console.WriteLine("Задан массив:\n");
int[,] array = new int[arrayRows, arrayColumns];
FillArray(array);                             // Запускаем функцию заполнения массива
PrintArray(array);                            // Выводим массив на экран
DetectMinRowSum();                            // Запускаем функцию опреления строки с наименьшей суммой


void FillArray(int[,] array)                  // Функция заполнения массива случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);  // в заданном диапазоне
        }
    }
}

void PrintArray(int[,] array)                 // Функция вывода массива на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine();
    }
}

void DetectMinRowSum()
{
    int currentMinStringValue = Int32.MaxValue;
    int currentIndexMinString = -1;
    for (int i = 0; i < arrayRows; i++)
    {
        int sumStringElement = 0;
        for (int j = 0; j < arrayColumns; j++)
        {
            sumStringElement += array[i, j];
        }
        if (sumStringElement < currentMinStringValue)
        {
            currentMinStringValue = sumStringElement;
            currentIndexMinString = i;
        }
    }
    Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {currentIndexMinString + 1}");
}