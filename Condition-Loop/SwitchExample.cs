using System;

public class Program
{
	public static void Main()
	{
		string Weapon = "Axe";
		switch (Weapon)
        {
			case "Sword":
				Console.WriteLine("Here is your sword, 150 cent");
				break;
			case "Axe":
				Console.WriteLine("Here is your Axe, 200 cent");
				break;
			case "Bow":
				Console.WriteLine("Here is your bow, 100 cent. You must buy some arrow to use it");
				break;
			default: Console.WriteLine("Latter");
				break ;
		}
	}
}