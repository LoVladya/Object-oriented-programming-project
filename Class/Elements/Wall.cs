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
            tryToGo = false;
        }
        public override void printColored()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(symbol.ToString() + ' ');
            Console.ResetColor();
        }
    }
}
