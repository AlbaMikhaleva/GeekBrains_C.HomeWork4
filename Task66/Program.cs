/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine ("Введите введите натуральное число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите введите натуральное число N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write ($"Сумма чисел от {m} до {n} равна {CalculationSum (m,n)}."); 

int CalculationSum (int m, int n){
    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        sum = sum + i;
    }
    return sum;
}
