using System;

public class Program
{
	public static void Main()
	{
		int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
		nums.Max();
		Console.WriteLine("Max: "+nums.Max());
		Console.WriteLine("Min: "+nums.Min());
		Console.WriteLine("Sum: "+nums.Sum());

		Array.Reverse(nums);

		Console.WriteLine("array after reverse");
		foreach(int i in nums)
        {
			Console.WriteLine(i+" ");
        }
		Console.WriteLine(Array.BinarySearch(nums,5));
		
	}
}