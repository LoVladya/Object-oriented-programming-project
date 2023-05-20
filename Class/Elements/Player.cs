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
        public Inventory inventory;

        public Player() : base('☺')
        {
        }
        public Player(string name, int health, Inventory inventory) : base('☺')
        {
            this.name = name;
            this.inventory = inventory;
            Health = health;
        }

        public int Health
        {
            get => health;
            set
            {
                if (value < 0 && inventory.Armour > 0)
                {
                    inventory.Armour = value;
                }
                else
                {
                    health += value;
                }
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

        public override void PrintColored()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(symbol.ToString() + ' ');
            Console.ResetColor();
        }
    }
}
