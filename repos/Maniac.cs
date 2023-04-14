using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    class Maniac : Coordinates
    {
        private string name = "Маніяк";
        private static int health = 30;
        public Maniac(int health) : base(7, 2)
        {
            Health = health;
        }
        public static int Health
        {
            get => health;
            set
            {
                health += value;
            }
        }
    }
}
