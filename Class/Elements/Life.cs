using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    class Life : ChangingElem
    {
        public Life() : base('♥')
        {
        }
        public override void PrintColored()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(symbol.ToString() + ' ');
            Console.ResetColor();
        }
        public override void Actions(Player player)
        {
            player.Health = 1;
        }
    }
}
