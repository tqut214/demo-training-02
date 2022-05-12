using System;
public class Enemy{
    public int HP { get; set; }
    public string Name { get; set; }
    public void isDead()
    {
        if (HP > 0)
        {
            Console.WriteLine("This still alive enemy with " + HP + " hp");
        }
        else
        {
            Console.WriteLine("Enemy Died");
        }
    }
   
}
public class Program
{
    public static void Main()
    {
        Enemy enemy = new Enemy();
        Console.WriteLine("Enter current HP of enemy");
        enemy.HP = Convert.ToInt32(Console.ReadLine());
        enemy.isDead();
        Console.WriteLine("hello");

    }
}
