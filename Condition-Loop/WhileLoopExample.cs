using System;

public class Program
{
	public static void Main()
	{
		int i = 0;

		while (true)
		{
			Console.WriteLine("i = {0}", i);
			i++;

			if (i > 10)
				break;
		}
	}
}