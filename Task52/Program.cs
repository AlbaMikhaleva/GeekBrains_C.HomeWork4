/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int [,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3, }, {8, 4, 2, 4} };

FindArithmeticMean (array);

void FindArithmeticMean (int [,] array) {
    double summElements = 0;

    for (int i = 0; i < array.GetLength(1); i++){
    for (int j = 0; j < array.GetLength(0); j++) {
        summElements = summElements + array[j,i];
        }
    Console.WriteLine("{0:F1}", summElements/array.GetLength(0));
    summElements = 0;
    }
}

