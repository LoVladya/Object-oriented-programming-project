using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    class Wall : Elements
    {
        public Wall() : base('#')
        {
            tryToGo = false;
        }
    }
}
