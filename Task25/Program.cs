/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/


Console.WriteLine ("Введите число A:");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB;

while (true) {
Console.WriteLine ("Введите натуральное число B:");
numberB = Convert.ToInt32(Console.ReadLine());
if (numberB >= 0) {
    break;
} else {
    Console.WriteLine ($"Число {numberB} НЕнатуральное.");
}
}
int result = Exponentiate (numberA, numberB);

Console.WriteLine ($"{numberA} в степени {numberB} = {result}");

int Exponentiate (int numberA, int numberB) 
{
    int result = numberA;
    if (numberB > 0) {
    for (int i = 1; i < numberB; i++) {
        result = result * numberA;
    }
    } else if (numberB == 0) {
        result = 1;
    }
    return result;
}
