using System;

public class Program
{
    static void Main(string[] args)
    {
        int id = 1;
        string name = "Tan";
        string job = "Knight";
        var person = GetPerson(id, name, job);
        Console.WriteLine(person);
    }

    static Tuple<int, string, string> GetPerson(int id, string name, string job)
    {
        return Tuple.Create(id, name, job);
    }
}