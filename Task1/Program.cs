// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 1-е число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3-е число: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;

Console.Write("max = ");
Console.WriteLine(max);