/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine ("Введите введите натуральное число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите введите натуральное число N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ($"Функция Аккермана для значений M={m}, N={n} равна {AckermannCalc(m,n)}.");

int AckermannCalc (int m, int n){

    if (m == 0) {
        return n+1;
    } else if (n == 0){
        return AckermannCalc(m-1, 1);
    } else {
        return AckermannCalc(m-1, AckermannCalc(m, n-1));
    }
}


