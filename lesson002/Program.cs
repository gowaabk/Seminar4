/* 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
    3 -> Среда 
5 -> Пятница */

Console.Write("Введите День от 1 до 7 ");
int dayNum = int.Parse(Console.ReadLine()); // Преобразует ввведенну строку в число.
if (dayNum > 1 && dayNum < 7)
{
    if (dayNum == 1) Console.Write($" {dayNum} - это Понедельник ");
    if (dayNum == 2) Console.Write($" {dayNum} - это Вторник ");
    if (dayNum == 3) Console.Write($" {dayNum} - это Среда ");
    if (dayNum == 4) Console.Write($" {dayNum} - это Четверг ");
    if (dayNum == 5) Console.Write($" {dayNum} - это Пятница ");
    if (dayNum == 6) Console.Write($" {dayNum} - это Суббота ");
    if (dayNum == 7) Console.Write($" {dayNum} - это Воскресение ");
}
else
{
    Console.WriteLine("It is Bad day Daddy!");
}