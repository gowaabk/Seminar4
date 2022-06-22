/* 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
    3 -> Среда 
5 -> Пятница */

Console.Write("Введите число от 1 до 7 ");
int numA = int.Parse(Console.ReadLine()); // Преобразует ввведенну строку в число.

if (numA == 1)
{
    Console.Write($" {numA} - это Понедельник ");
}
if (numA == 2)
{
    Console.Write($" {numA} - это Вторник ");
}
if (numA == 3)
{
    Console.Write($" {numA} - это Среда ");
}
if (numA == 4)
{
    Console.Write($" {numA} - это Четверг ");
}
if (numA == 5)
{
    Console.Write($" {numA} - это Пятница ");
}
if (numA == 6)
{
    Console.Write($" {numA} - это Суббота ");
}
if (numA == 7)
{
    Console.Write($" {numA} - это Воскресение ");
}