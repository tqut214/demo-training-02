using System;

public class Program
{
	public static void Main()
	{
		ValueTuple<int, string, string> person1 = (1, "Bill", "Gates");
		Console.WriteLine(person1.Item1); 
		Console.WriteLine(person1.Item2); 
		Console.WriteLine(person1.Item3); 

		(int, string, string) person2 = (1, "James", "Bond");
		Console.WriteLine(person2.Item1); 
		Console.WriteLine(person2.Item2); 
		Console.WriteLine(person2.Item3); 
		//naming tupletype
		(int Id, string FirstName, string LastName) person = (1, "Bill", "Gates");
		Console.WriteLine(person.Id); 
		Console.WriteLine(person.FirstName);
		Console.WriteLine(person.LastName); 
	}
}