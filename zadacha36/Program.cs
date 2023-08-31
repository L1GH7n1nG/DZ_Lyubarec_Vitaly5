int[] FillArray(int size, int min, int max)
{
	int[] arr = new int[size];
	Random massiv = new Random();
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = massiv.Next(min, max + 1);
	}
	return arr;
}

void PrintArray(int[] arr)
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

int SumOdd(int[] arr)
{
	int sum = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		if (i % 2 == 1) sum += arr[i];
	}
	return sum;
}

int[] array = FillArray(10, -100, 100);
PrintArray(array);
Console.WriteLine($" -> сумма нечётных элементов массива = {SumOdd(array)}");


