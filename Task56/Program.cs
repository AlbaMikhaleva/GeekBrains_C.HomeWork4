/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки
 с наименьшей суммой элементов: 1 строка */

 int [,] array = { {1, 4, 7, 2}, { 5, 9, 2, 3, }, {8, 4, 2, 4}, {5, 2, 6, 7}}; 
PrintArray (array, "Вывод исходного массива");

Console.WriteLine ("Строка №" + SearchIndexMinSun (array) + " с наименьшей суммой");

// Поиск строки с минимальной суммой
int SearchIndexMinSun (int [,] array) {

    int indexRowMin = 0;
    int minSumRow = CalculateSum1Row (array);

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow = sumRow + array [i,j];
        }

        if (minSumRow > sumRow) {
            minSumRow = sumRow;
            indexRowMin = i;
        }
    }

    return indexRowMin+1;
}

// Вычисление суммы 1 строки
int CalculateSum1Row (int [,] array) {
    int sumRow = 0;

    for (int i = 0; i < array.GetLength(0); i++) {
        sumRow = sumRow + array [0,i];
    }
    
    return sumRow;
}

// Метот вывода массива 
void PrintArray (int [,] array, String message) {
Console.WriteLine (message);
for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++) {
        Console.Write (array [i,j] + " ");
        }
    Console.WriteLine();
}
Console.WriteLine();
}
