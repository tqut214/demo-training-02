using System;
using System.Text;

public class Program
{
	

	public static void Main()
	{
		var Enemy = new { name = "Dracula", hp = 10f, speed = 10f };
		Console.WriteLine(Enemy.name);
		Console.WriteLine(Enemy.hp);	
		Console.WriteLine(Enemy.speed);
	}
}