using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    class Items : Coordinates
    {
        private bool itemUpgrade;
        private bool armor;
        private int traps;
        public Items(bool itemUpgrade, bool armor, int traps) : base(1, 1)
        {
            this.itemUpgrade = itemUpgrade;
            this.armor = armor;
            this.traps = traps;
        }
    }
}
