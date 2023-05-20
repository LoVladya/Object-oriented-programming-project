using System;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading;

namespace Object_oriented_programming_project
{
    abstract class Element : Coordinates
    {
        public char symbol;
        public bool isWalkable = true;
        
        public Element(char symbol)
        {
            this.symbol = symbol;
        }
        public virtual void PrintColored()
        {
        }
        public virtual void Actions(Player player) 
        {
        }
    }
}