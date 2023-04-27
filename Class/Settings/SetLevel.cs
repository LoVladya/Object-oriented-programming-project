using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    internal class SetLevel:Settings
    {
        
        public TextWriter writer = new StreamWriter(@"..\..\Class\Motor\settings.txt");
        public void SizeField()
        {
            Console.WriteLine("Натисніть клавішу для вибору складності: e - easy, m - medium, h - HARD");
            if (!Console.KeyAvailable)
            {
                
                ConsoleKeyInfo keyLevel = Console.ReadKey(true);
                switch (keyLevel.Key)
                {
                    case ConsoleKey.E:
                        writer.WriteLine("easy");
                        break;

                    case ConsoleKey.M:
                        writer.WriteLine("medium");
                        break;

                    case ConsoleKey.H:
                        writer.WriteLine("hard");
                        break;
                }
                writer.Close();
            }
        }
    }
}
