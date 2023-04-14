using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{

    class Coordinates
    {
        public int x;
        public int y;
        public int X
        {
            get => x;
            set
            {
                if (value < 0)
                    x = 0;
                else
                    x = value;
            }
        }
        public int Y
        {
            get => y;
            set
            {
                if (value < 0)
                    y = 0;
                else
                    y = value;
            }
        }
        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
