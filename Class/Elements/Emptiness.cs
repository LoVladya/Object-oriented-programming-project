using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    class Emptiness : DesignElem
    {
        public Emptiness() : base(' ')
        {
        }
        public override void printColored()
        {
            Console.Write(symbol.ToString() + ' ');
        }
    }
}
