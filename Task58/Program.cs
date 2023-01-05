/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

int [,] matrixOne = new int [2,2];
matrixOne = FillMatrix (matrixOne, matrixOne.GetLength(0), matrixOne.GetLength(1));
PrintArray(matrixOne, "Вывод ПЕРВОЙ матрицы");

int [,] matrixTwo = new int [2,2];
matrixTwo = FillMatrix (matrixTwo, matrixTwo.GetLength(0), matrixTwo.GetLength(1));
PrintArray(matrixTwo, "Вывод ВТОРОЙ матрицы");

MultiplicationMatrix (matrixOne, matrixTwo);

// Заполнение матрицы случайными числами
int [,] FillMatrix (int [,] matrix, int row, int column ) {
    Random random = new Random ();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix [i,j] = random.Next(0, 10);
        }
    }

    return matrix;
}

//Произведение матриц
void MultiplicationMatrix (int [,] matrixOne, int [,] matrixTwo) {

    if (matrixOne.GetLength(1) != matrixTwo.GetLength(0)) {
        Console.WriteLine ("Матрицы нельзя перемножить");
    } else {

        int [,] multiMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
        for (int i = 0; i < multiMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < multiMatrix.GetLength(1); j++)
            {
                multiMatrix[i, j] = 0;
                for (int n = 0; n < matrixOne.GetLength(1); n++)
                {
                    multiMatrix[i, j] += matrixOne[i, n] * matrixTwo[n, j];
                }
            }
        }
        PrintArray (multiMatrix, "Вывод произведения матриц.");
    }
}

//Вывод массива (матрицы)
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
