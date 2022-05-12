using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		SortedList<int, string> EnemyName = new SortedList<int, string>()
									{
										{3, "Dracula"},
										{1, "Zombie"},
										{2, "Dog"}
									};

		Console.WriteLine(EnemyName[1]); 
		Console.WriteLine(EnemyName[2]);
		Console.WriteLine(EnemyName[3]); 

	}
}