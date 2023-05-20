using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Object_oriented_programming_project
{
    internal class MapDifficulty : Settings
    {
        public TextWriter writer;
        public void LevelSetter()
        {
            writer = new StreamWriter(@"settings.txt");
            Console.WriteLine("Натисніть клавішу для вибору складності: e - easy, m - medium, h - HARD");
            ConsoleKey key = Console.ReadKey(true).Key;
            Dictionary<ConsoleKey, Action> levels = new Dictionary<ConsoleKey, Action>()
            {
                { ConsoleKey.E, () => writer.WriteLine("easy") },
                { ConsoleKey.M, () => writer.WriteLine("medium") },
                { ConsoleKey.H, () => writer.WriteLine("hard") },
            };

            levels[key]();
            writer.Close();
        }
    }
}
