using System;
public class Program{
    struct Character
    {
        public string Name;
        public int HP;
        public int MP;
        public int level;
        public int ATK;
        public int DEF;
    }
    
   
    public static void Main(string[] args){
        Character c = new Character();
        c.Name = "QT";
        c.HP = 100;
        c.MP = 50;
        c.level = 1;
        c.ATK = 4;
        c.DEF = 5;
        Console.WriteLine("This is " + c.Name + " have " + c.HP + " HP");
  
    
}
}
