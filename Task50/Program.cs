/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */


int [,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3, }, {8, 4, 2, 4} };

PrintArray (array);
SearchElement (array);

// Метод поиска элемента
void SearchElement (int [,] array) {
Console.WriteLine ("Введите индекс элемента");

int index = int.Parse(Console.ReadLine());
int m = index/10;
int n = index%10;

if ((m > array.GetLength(0)) || (n > array.GetLength(1))) {
Console.WriteLine ("Такого элемента нет");
} else {
   Console.WriteLine ($"Элемент {array [m,n]}"); 
}
}

// Метот вывода массива 
void PrintArray (int [,] array) {
Console.WriteLine ("Вывод массива");
for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++) {
        Console.Write (array [i,j] + " ");
        }
    Console.WriteLine();
}
}
