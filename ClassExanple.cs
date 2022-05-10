
Console.WriteLine("Hello, World!");
Character c1 = new Character("Tan");
c1.Introduction();
public class Character
{
    public Character(string name)
    {
        this.Name = name;
    }
    public string Name { get; set; }
    public string Description { get; set; }

    
    public void Introduction()
    {
        Console.WriteLine("Hello my name is " + Name);

    }
}