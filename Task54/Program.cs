﻿/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int [,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3, }, {8, 4, 2, 4} };
PrintArray (array, "Вывод исходного массива");

int [] arrayRow = new int [array.GetLength(1)];

for (int i = 0; i < array.GetLength(0); i++)
{
    arrayRow = CopyInArrayRow (array, i);
    Array.Sort(arrayRow);
    Array.Reverse(arrayRow);
    array = CopyFromArrayRow (array, arrayRow, i);
}

PrintArray (array, "Вывод отсортированного массива");

// Запись элементов строки в отдельный массив
int [] CopyInArrayRow (int [,] array, int i) {
    int [] copyArrayRow = new int [array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++) {
        copyArrayRow [j] = array [i,j];
    }

    return copyArrayRow;
}

// Копирование из отсортировонного строчного массива в основной 
int [,] CopyFromArrayRow (int [,] array, int [] arrayRow, int i) {
    
    for (int j = 0; j < array.GetLength(1); j++) {
        array [i,j] = arrayRow [j];
    }
    
    return array;
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
