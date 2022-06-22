/* Напишите программу, которая на вход принимает два числа
и проверяет, является ли первое число квадратом второго.
a = 5; b = 25->да
a = 2 b = 10->нет
a = 9; b = -3->нет
a = -3 b = 9->да */

Console.Write("Введите первое число ");
int numA = int.Parse(Console.ReadLine()); // Преобразует ввведенну строку в число.
Console.Write("Введите второе число ");
int numB = int.Parse(Console.ReadLine());
int square = numA * numA;
if (square == numB)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("Нет");
}

