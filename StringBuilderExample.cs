using System;
using System.Text;

public class Program
{
	private static void ReplaceString()
    {
		StringBuilder sb = new StringBuilder("Hello World!!", 50);
		sb.Replace("World", "C#");

		Console.WriteLine(sb);
	}
	private static void Remove()
    {
		StringBuilder sb = new StringBuilder("Hello World!", 50);
		sb.Remove(6, 7);

		Console.WriteLine(sb); //output: Hello
	}
	private static void InsertString() {
		StringBuilder sb = new StringBuilder("Hello World!");
		sb.Insert(5, " C#");

		Console.WriteLine(sb); //output: Hello C# World!
	}
	private void AddString()
    {
		StringBuilder sb = new StringBuilder();
		sb.Append("Hello ");
		sb.AppendLine("World!");
		sb.AppendLine("Hello C#");
		Console.WriteLine(sb);
	}

	public static void Main()
	{
		
	}
}