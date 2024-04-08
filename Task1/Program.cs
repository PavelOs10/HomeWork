﻿// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
// M = 8; N = 4 -> "8, 7, 6, 5, 4"


void NumberFromMtoN(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m}");
        return;
    }
    Console.Write($"{m}, ");
    NumberFromMtoN(m + 1, n);
}
void NumberFromNtoM(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m}");
        return;
    }
    Console.Write($"{m}, ");
    NumberFromNtoM(m - 1, n);
}
void Exam(int m, int n)
{
    if (m < n)
    {
        NumberFromMtoN(m, n);
    }
    else if (m > n)
    {
        NumberFromNtoM(m, n);
    }
    else
    {
        Console.Write(n); // or "m", becouse m = n
    }
}

Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());

Exam(m, n);