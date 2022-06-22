/* 3. Напишите программу вычисления функции:
 x = f(a)
 Вычисления функции куба числа.
 */

Console.Write("Введите число ");
int numA = int.Parse(Console.ReadLine());
int kub = numA * numA * numA;

Console.WriteLine($"куб числа равен {kub}");
