using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    internal class Output
    {
        public void PrintGameField(Map map) // Друк ігрового поля
        {
            Console.Clear();
            for (int i = 0; i < map.width; i++)
            {
                for (int j = 0; j < map.height; j++)
                {
                    map[i, j].printColored();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void PrintInfo(Player player, Inventory inventory, Maniac maniac)
        {
            Console.WriteLine("Кількість життів: " + player.Health);
            Console.WriteLine("Кількість броні: " + inventory.Armour);
            Console.WriteLine("Життя маніяка: " + maniac.Health);
        }
    }
}
