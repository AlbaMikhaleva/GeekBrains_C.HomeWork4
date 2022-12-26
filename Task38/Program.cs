/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

double [] array = {3, 7, 22, 2, 78};
    double min = array [0];
    double max = array [0];

    for (int i = 1; i < 5; i++) {
        if (max < array [i]) {
            max = array [i];
        } else if (min > array [i]) {
            min = array [i];
        }
    }

        Console.Write (max - min);

    
