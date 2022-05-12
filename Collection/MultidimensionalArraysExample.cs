using System;

public class Program
{
	public static void Main()
	{
		int[,,,] arr4d1 = new int[1, 1, 2, 2]{
			{
				{{1, 2}, {3, 4}}
			}
		};

		int[,,,] arr4d2 = new int[1, 2, 2, 2]{
			{
				{{1, 2}, {3, 4}},
				{{5, 6}, {7, 8}}
			}
		};

		Console.WriteLine("arr4d1");
		Console.WriteLine(arr4d1[0, 0, 0, 0]);
		Console.WriteLine(arr4d1[0, 0, 0, 1]);
		Console.WriteLine(arr4d1[0, 0, 1, 0]);
		Console.WriteLine(arr4d1[0, 0, 1, 1]);

		Console.WriteLine("arr4d2");
		Console.WriteLine(arr4d2[0, 0, 0, 0]);
		Console.WriteLine(arr4d2[0, 0, 0, 1]);
		Console.WriteLine(arr4d2[0, 0, 1, 0]);
		Console.WriteLine(arr4d2[0, 0, 1, 1]);
		Console.WriteLine(arr4d2[0, 1, 0, 0]);
		Console.WriteLine(arr4d2[0, 1, 0, 1]);
		Console.WriteLine(arr4d2[0, 1, 1, 0]);
		Console.WriteLine(arr4d2[0, 1, 1, 1]);
	}
}