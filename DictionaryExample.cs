using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		IDictionary<int, string> HerosName = new Dictionary<int, string>();
		HerosName.Add(1, "Zeus"); //adding key/value using the Add() method
		HerosName.Add(3, "Thor");
		HerosName.Add(2, "Loki");

		foreach (KeyValuePair<int, string> kvp in HerosName)
			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
			
		if (HerosName.ContainsKey(4))//check unknow key
		{
			HerosName[4] = "Hera";
        }
        else 
		{
			Console.WriteLine("No hera");
		}
		HerosName.Add(4, "Hera");
		Console.WriteLine("Dictionary after update");
		foreach (KeyValuePair<int, string> kvp in HerosName)
			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);


	}
}