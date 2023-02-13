// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine());
if (value % 2 == 0)
	Console.WriteLine("число " + value + " - четное!");
else
	Console.WriteLine("число " + value + " - НЕчетное!");