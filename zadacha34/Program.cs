int[] FillArray(int size, int min, int max)
{
	int[] arr = new int[size];
	Random massiv = new Random();
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = massiv.Next(min, max);
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

int FindEven(int[] arr)
{
	int count = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] % 2 == 0) count++;
	}
	return count;
}

int[] array = FillArray(10, 100, 1000);
PrintArray(array);
Console.Write($" -> количество чётных чисел в массиве - {FindEven(array)}");