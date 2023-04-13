using System;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading;

namespace Object_oriented_programming_project
{
    internal class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Motor game = new Motor();
            game.GameProcess();
        }
    }
}