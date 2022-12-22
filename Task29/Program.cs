/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.WriteLine ("Введите размер массива:");

int size = int.Parse(Console.ReadLine());
int [] array = new int [size];

Random random = new Random();

for (int i = 0; i < size; i++) {
array[i] =  random.Next(0, 100);
}

PrintArray (array, size);


void PrintArray (int [] array, int size)
{
for (int i = 0; i < size; i++) {
    if (i == 0) {
Console.Write("[" + array[i] + ", ");
    } else if ((i > 0) & (i < size-1)) {
        Console.Write(array[i]+ ", ");
    } else if (i == size-1) {
        Console.Write(array[i]+ "]");
    }
}
}
