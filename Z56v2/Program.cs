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

CountMinRowSum();


void CountMinRowSum()
{
    int arrayRows = new Random().Next(3, 5);      // Генерируем кол-во строк в заданном диапазоне
    int arrayColumns = new Random().Next(3, 9);   // Генерируем кол-во столбцов в заданном диапазоне
    int arrayMaxValue = 10;                       // Максимальное значение элемента в массиве -1
    int arrayMinValue = 1;                        // Минимальное значение элемента в массиве

    Console.WriteLine("Задан массив:\n");
    int[,] array = new int[arrayRows, arrayColumns];

    int currentMinStringValue = Int32.MaxValue;   // Переменная для сохранения мин. суммы элементов в строке
    int currentIndexMinString = -1;               // Переменная для сохранения индекса строки с мин. суммой
    int sumStringElement = 0;                     // Переменная для промежут. сохр. суммы элементов в строке

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            array[i, j] = new Random().Next(arrayMinValue, arrayMaxValue);  // Заполняем массив
            Console.Write($"{array[i, j],4}");                              // Выводим массив
            sumStringElement += array[i, j];                                // Считаем сумму элем. в строке
        }
        Console.WriteLine("   <-- row " + (i + 1) + "  sum = " + sumStringElement); // Выводим номер строки и сумму
        if (sumStringElement < currentMinStringValue)
        {
            currentMinStringValue = sumStringElement;                       // Сохраняем мин. сумму элем. в строке
            currentIndexMinString = i;                                      // Сохраняем индекс строки с мин. суммой
        }
    }
    Console.WriteLine("\nСтрока с наименьшей суммой элементов: " + (currentIndexMinString + 1) + "   сумма = " + currentMinStringValue);
}