using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Stack<int> myStack = new Stack<int>();
		myStack.Push(1);
		myStack.Push(2);
		myStack.Push(3);
		myStack.Push(4);

		Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

		if (myStack.Count > 0)
		{
			Console.WriteLine("whether item 5 exists in the stack or not");
			Console.WriteLine(myStack.Contains(5));
			Console.WriteLine("the top item from the stack");
			Console.WriteLine(myStack.Peek());
		}

		Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);
	}
}