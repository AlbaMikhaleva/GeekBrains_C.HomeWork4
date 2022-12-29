/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.WriteLine ("Введите количество чисел:");

int m = int.Parse(Console.ReadLine());
int [] numbers = InitArrayNumbers (m);

Console.WriteLine ("Количество положительных чисел = " + CountingPositiveNumbers (numbers));

int [] InitArrayNumbers (int m) {
string[] numberStr;

do {
Console.WriteLine ($"Введите {m} числа(ел) через пробел:");
numberStr = Console.ReadLine().Split();
}
while (numberStr.Length != m);

int[] numbers = new int[m];
for (int i = 0; i < m; i++) {
    numbers[i] = Convert.ToInt32(numberStr[i]);
}
return numbers;
}

int CountingPositiveNumbers (int [] numbers) {
    int count = 0;
    for (int i = 0; i < numbers.Length; i++) {
        if (numbers [i] >= 0) {
            count++;
        }
    }
    return count;
}

