// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int nEven = 2;

if (N>1)
{
	Console.Write("Четные числа между 1 и N: ");
	while (nEven<=N)
	{
		Console.Write(nEven + ", ");
		nEven +=2;
	}
}
else
	Console.WriteLine("Четные числа между 1 и N ОТСУТСТВУЮТ");