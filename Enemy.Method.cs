using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpStudy2
{
    public partial class Enemy
    {
        public  Enemy(string name, int ATK)
        {
            this.Name = name;
            this.ATKpower = ATK;
        }
        public void EnemyATK()
        {
            Console.WriteLine("Enemy attack with " + ATKpower +"damage");
        }
    }
}
