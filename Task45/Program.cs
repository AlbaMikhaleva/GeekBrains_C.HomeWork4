/*  Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.*/

int [] array = {3, 7, 22, 2, 78};
//int [] arrayClone = C

Console.WriteLine ("Исходный массив array: ");
PrintArray (array);

Console.WriteLine ("Копия массива array: ");
PrintArray (CopyArray(array));

int [] CopyArray (int [] array) {
    int [] arrayClone =  new int [array.Length];

    for (int i = 0; i < array.Length; i++){
    arrayClone [i] = array [i];
    }

    return arrayClone;
}

void PrintArray (int [] array) {
for (int i = 0; i < array.Length; i++){
    Console.Write (array [i] + " ");
}
Console.WriteLine();

}
