using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    class Player : Coordinates
    {
        private string name = "Player";
        private static int health = 10;
        private int score;

        public static int Health
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

        public Player(string name, int health) : base(3, 3)
        {
            this.name = name;
            Health = health;
        }
    }
}
