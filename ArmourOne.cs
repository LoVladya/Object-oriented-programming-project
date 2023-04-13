using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    class ArmourOne : Elements // +1 броня
    {
        public ArmourOne() : base('1')
        {
        }
        public override void Activity()
        {
            Inventory.Armour = 1;
        }
    }
}
