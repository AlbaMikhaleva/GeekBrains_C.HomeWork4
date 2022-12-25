/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.WriteLine ("Введите размер массива:");

int size = int.Parse(Console.ReadLine());

int [] array = InitArray (size);
PrintArray (array);
CalculateSumm (array);

int [] InitArray (int size) {

int [] array = new int [size];

Random random = new Random();

for (int i = 0; i < size; i++) {
array[i] =  random.Next(-100, 101);
}
return array;
}


void PrintArray (int [] array) {
for (int i = 0; i < array.Length; i++) {
Console.Write (array[i] + " ");
    } 
    Console.WriteLine();
}

void CalculateSumm (int [] array){
    int summ = 0;
    int i = 1;
    while (i < array.Length) {
        summ = summ + array[i];
        i = i + 2;
    }
    Console.WriteLine (summ);
}
