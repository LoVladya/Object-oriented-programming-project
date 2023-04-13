using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    class Trap : Elements
    {
        public Trap() : base('†')
        {
            tryToGo = true;
        }
        public override void Activity()
        {
            Player.Health = -1;
        }
    }
}
