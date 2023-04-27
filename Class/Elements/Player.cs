using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    class Player : WalkingElem
    {
        private string name = "Player";
        private int health = 0;
        private int score;

        public int Health
        {
            get => health;
            set
            {
                health += value;
            }
        }
        public int Score
        {
            get => score;
            set
            {
                score += value;
            }
        }

        public Player() : base('☺')
        {
        }
        public override void printColored()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(symbol.ToString() + ' ');
            Console.ResetColor();
        }
        public Player(string name, int health) : base('☺')
        {
            this.name = name;
            Health = health;
        }
    }
}
