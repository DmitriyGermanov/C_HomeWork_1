﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int n = 2;

while (n < number)
{
    if (n == number -2 || n == number -1) Console.Write(n);
    else Console.Write(n + ", ");
    n = n +2;
}