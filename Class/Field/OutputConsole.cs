using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    internal class OutputConsole
    {
        public void PrintInfoAndField(Element[,] map, Player player, Inventory inventory, Maniac maniac) // Друк ігрового поля
        {
            Console.Clear();
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j].PrintColored();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Кількість життів: " + player.Health);
            Console.WriteLine("Кількість броні: " + inventory.Armour);
            Console.WriteLine("Життя маніяка: " + maniac.Health);
            Console.WriteLine();
        }
    }
}
