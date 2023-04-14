using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    class Inventory
    {
        private static int armour;
        private int weaponLevel;
        public Inventory()
        {
            armour = 0;
            weaponLevel = 0;
        }
        public int WeaponLevel
        {
            get => weaponLevel;
            set
            {
                weaponLevel += value;
            }
        }
        public static int Armour
        {
            get => armour;
            set
            {
                armour += value;
            }
        }
    }
}
