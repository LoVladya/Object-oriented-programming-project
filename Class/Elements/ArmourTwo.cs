using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    class ArmourTwo : ChangingElem // +2 броня
    {
        public ArmourTwo() : base('2')
        {
        }
        public override void printColored()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(symbol.ToString() + ' ');
            Console.ResetColor();
        }
        public override void Activity(Player player, Inventory inventory)
        {
            inventory.Armour = 2;
        }
    }
}
