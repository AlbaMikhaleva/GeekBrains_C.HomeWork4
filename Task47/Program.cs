/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

string[] numberStr;

Console.WriteLine ("Введите размер двумерного массива:");
numberStr = Console.ReadLine().Split();

int m = Convert.ToInt32(numberStr[0]);
int n = Convert.ToInt32(numberStr[1]);

double [,] array = InitArrayNumbers (m,n);
PrintArray (array);

// Метод заполнения массива
double [,] InitArrayNumbers (int m, int n) {

double [,] array = new double [m,n];
Random random = new Random();

for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
array[i,j] =  Math.Round (random.NextDouble() * (20 - (-20)) + (-20),1);
}
}
return array;
}

// Метот вывода массива 
void PrintArray (double [,] array) {
for (int i = 0; i < m; i++){
    for (int j = 0; j < n; j++) {
            Console.Write (array [i,j] + " ");
        }
        Console.WriteLine();
}
}

