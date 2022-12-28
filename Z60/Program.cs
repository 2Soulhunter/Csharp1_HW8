/*                          Домашнее задание к семинару 8 С#
Задача 60: Сформируйте трёхмерный массив из неповторяющихся (HARD - случайные уникальные) двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Например:
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)                     */

int arrayMaxValue = 100;     // Максимальное значение элемента в массиве -1
int arrayMinValue = 10;      // Минимальное значение элемента в массиве
int arraySize = 2;           // Размерность массива
int[,,] array = new int[arraySize, arraySize, arraySize];   // Создаём трёхмерный массив
FillArray();                 // Запуск функции заполнения массива
ShowIndexArray();            // Запуск функции вывода массива с индексом каждого элемента


void FillArray()             // Функция заполнения массива случайными уникальными числами
{
    int[] Array = new int[arraySize * arraySize * arraySize];
    int temp;
    for (int i = 0; i < Array.Length; i++) 
    {
        while (Array[i] == 0)
        {
            temp = new Random().Next(arrayMinValue, arrayMaxValue);
            if (Array.IndexOf(Array, temp, i) == -1)
            {
                Array[i] = temp;
            }
        }
    }
}
    
void ShowIndexArray()       // Функция вывода массива с индексом каждого элемента
{   
    int count = 0;
    for (int arrayDepth1 = 0; arrayDepth1 < arraySize; arrayDepth1++)
    {
        for (int arrayDepth2 = 0; arrayDepth2 < arraySize; arrayDepth2++)
        {
            for (int arrayDepth3 = 0; arrayDepth3 < arraySize; arrayDepth3++)
            {
                array[arrayDepth1, arrayDepth2, arrayDepth3] = Array[count];
                count++;
                Console.WriteLine($"{array[arrayDepth1, arrayDepth2, arrayDepth3]} ({arrayDepth1},{arrayDepth2},{arrayDepth3})");
            }
        }
    }
}