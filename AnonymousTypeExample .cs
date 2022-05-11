using System;
using System.Text;

namespace QT
{
    class Program
    {
        
        static void Main(string[] args)
        {
            EnemyStat();
            
        }
       static void EnemyStat()
        {
            var Enemy = new
            {
                Name = "Dracula",
                Speed = 3.1f,
                Hp = 10,
            };
            Console.WriteLine(Enemy.Name+" have "+ Enemy.Speed+" movement speed and "+Enemy.Hp+" HP");
        }
    }
}