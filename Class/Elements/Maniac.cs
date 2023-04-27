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
        public Maniac(string name, int health) : base('☼')
        {
            Health = health;
            this.name = name;
            tryToGo = false;
        }
        public Maniac() : base('☼')
        {
        }
        public int Health
        {
            get => health;
            set
            {
                health += value;
            }
        }
        public override void printColored()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(symbol.ToString() + ' ');
            Console.ResetColor();
        }
    }
}
