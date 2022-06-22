// Напишите программу, которая на вход принимает число и выдаёт его квадрат
// (число умноженное на само себя).

Console.Write("VVedite chislo "); //Вывод в консоль приглашения
string chislo = Console.ReadLine(); // Ввод строки с консоли
int number = int.Parse(chislo); // Преобразование строки в целое число
int result = number * number; // Вычисление квадрата
Console.WriteLine($"Square {number} = {result}"); // вывод результата на экран
