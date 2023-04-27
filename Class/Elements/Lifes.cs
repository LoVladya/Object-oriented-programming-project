using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    class Lifes : ChangingElem
    {
        public Lifes() : base('♥')
        {
        }
        public override void printColored()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(symbol.ToString() + ' ');
            Console.ResetColor();
        }
        public override void Activity(Player player, Inventory inventory)
        {
            player.Health = 1;
        }
    }
}
