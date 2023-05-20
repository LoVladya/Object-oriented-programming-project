using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    class Wall : DesignElem
    {
        public Wall() : base('#')
        {
            isWalkable = false;
        }
        public override void PrintColored()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(symbol.ToString() + ' ');
            Console.ResetColor();
        }
    }
}
