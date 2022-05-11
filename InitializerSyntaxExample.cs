using System;

public class Weapon
{
	public float speed { get; set; }
	public string name { get; set; }
	public float damage { get; set; }
	public float weight { get; set; }

}
public class Program{
	static void Main(string[] args)
	{
		Weapon weapon = new Weapon()
		{
			speed = 1.0f,
			name = "Axe",
			damage = 10,
			weight = 20f
		};
		
		Console.WriteLine(weapon.name);

	}
}
