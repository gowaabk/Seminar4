﻿/* Напишите программу, которая на вход принимает одно число (N),
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
 */

Console.Write("Введите число ");
int numA = int.Parse(Console.ReadLine());

int count = -numA;

while (count < numA + 1)
{
    Console.Write($" {count} ");
    count++;
}