using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    class Maniac : WalkingElem
    {
        private string name = "Маніяк";
        private int health = 0;

        public int Health
        {
            get => health;
            set
            {
                health += value;
            }
        }
        public Maniac() : base('☼')
        {
        }
        public Maniac(string name, int health) : base('☼')
        {
            Health = health;
            this.name = name;
            isWalkable = false;
        }
        
        public override void PrintColored()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(symbol.ToString() + ' ');
            Console.ResetColor();
        }
    }
}
