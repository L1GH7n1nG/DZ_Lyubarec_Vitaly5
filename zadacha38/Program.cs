// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] FillArray(int size, int min, int max)
{
	double[] arr = new double[size];
	Random massiv = new Random();
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = Math.Round((massiv.NextDouble() * (max - min) + min), 2);
	}
	return arr;
}

void PrintArray(double[] arr)
{
	Console.Write("[");
	for (int i = 0; i < arr.Length; i++)
	{
		if (i < arr.Length - 1)
		{
			Console.Write($"{arr[i]}, ");
		}
		else Console.Write($"{arr[i]}");
	}
	Console.Write("]");
}

double FindDifferenceMaxMin(double[] arr)
{
	double min = arr[0];
	double max = arr[0];
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] > max) max = arr[i];
		if (arr[i] < min) min = arr[i];
	}
	double difference = Math.Round(max - min, 2);
	return difference;
}

double[] array = FillArray(7, 0, 100);
PrintArray(array);
double result = FindDifferenceMaxMin(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {result}");
