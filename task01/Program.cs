// Задача 4: Напишите программу,
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число 1: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.Write("Введите число 2: ");
int secondNumber = int.Parse(Console.ReadLine()!);

Console.Write("Введите число 3: ");
int thirdNumber = int.Parse(Console.ReadLine()!);

int maximum = firstNumber;

if (secondNumber > maximum)
    maximum = secondNumber;
if (thirdNumber > maximum)
    maximum = thirdNumber;

Console.WriteLine("Максимальное число: " + maximum);
