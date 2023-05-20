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
        public override void PrintColored()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(symbol.ToString() + ' ');
            Console.ResetColor();
        }
        public override void Actions(Player player)
        {
            player.inventory.Armour = 2;
        }
    }
}
