using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    class ArmourTwo : Elements // +2 броня
    {
        public ArmourTwo() : base('2')
        {
        }
        public override void Activity()
        {
            Inventory.Armour = 2;
        }
    }
}
