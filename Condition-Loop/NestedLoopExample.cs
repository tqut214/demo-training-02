using System;

public class Program
{
	public static void Main()
	{
		for (int i = 0; i < 2; i++)
		{
			for (int j = i; j < 4; j++)
				Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
		}
	}
}