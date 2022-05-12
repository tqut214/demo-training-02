using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		// adding elements using add() method
		var primeNumbers = new List<int>();
		primeNumbers.Add(1);
		primeNumbers.Add(3);
		primeNumbers.Add(5);
		primeNumbers.Add(7);

		Console.WriteLine("No of elelemts: " + primeNumbers.Count);

		var Weapon = new List<string>();
		Weapon.Add("Axe");
		Weapon.Add("Bow");
		Weapon.Add("Sword");
		Weapon.Add("Staff");
		
		Console.WriteLine("No of weapons: " + Weapon.Count);
		Console.WriteLine("Weapon list");
		for (int i = 0; i < Weapon.Count; i++)
			Console.WriteLine(Weapon[i]);

		// adding elements using collection initializer syntax
		var bigCities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };

		Console.WriteLine("No of bigcitys: " + bigCities.Count);

		var enemys = new List<Enemy>() {
				new Enemy(){ Id = 1, Name="Bill"},
				new Enemy(){ Id = 2, Name="Steve"},
				new Enemy(){ Id = 3, Name="Ram"},
				new Enemy(){ Id = 4, Name="Abdul"}
			};

		Console.WriteLine("No of enemy: " + enemys.Count);
	}
}

class Enemy
{
	public int Id { get; set; }
	public string Name { get; set; }
}