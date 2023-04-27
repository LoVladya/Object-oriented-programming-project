using System;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading;

namespace Object_oriented_programming_project
{
    abstract class Elements : Coordinates
    {
        public char symbol;
        public virtual void printColored()
        {
        }
        public bool tryToGo = true;
        public Elements(char symbol)
        {
            this.symbol = symbol;
        }
        public virtual void Activity(Player player, Inventory inventory) 
        {
        }
    }
}