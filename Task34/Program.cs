/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.WriteLine ("Введите размер массива:");

int size = int.Parse(Console.ReadLine());

int [] array = InitArray (size);
PrintArray (array);
CountEven(array);


int [] InitArray (int size) {

int [] array = new int [size];

Random random = new Random();

for (int i = 0; i < size; i++) {
array[i] =  random.Next(100, 1000);
}
return array;
}

void CountEven (int [] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if ( array [i] % 2 == 0) {
            count++;
        }
    }
    Console.WriteLine (count);
}

void PrintArray (int [] array) {
for (int i = 0; i < array.Length; i++) {
Console.Write (array[i] + " ");
    } 
    Console.WriteLine();
}

