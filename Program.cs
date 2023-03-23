using System;

namespace Object_oriented_programming_project
{
    internal class Program
    {
        class Player
        {
            public string name { get; set; }
            public int x { get; set; }
            public int y { get; set; }
            public int weaponLevel { get; set; } = 0;

            public Player(string Name, int X, int Y, int WeaponLevel)
            {
                this.name = Name;
                this.x = X;
                this.y = Y;
                this.weaponLevel = WeaponLevel;
            }
        }
        class Items
        {
            public bool itemUpgrade;
            public bool armor;
            public int traps;
            public Items(bool itemUpgrade, bool armor, int traps)
            {
                this.itemUpgrade = itemUpgrade;
                this.armor = armor;
                this.traps = traps;
            }
        }
        class Map
        {
            private int[,] map;
            public Map(int width, int height)
            {
                this.map = new int[width, height];
            }
        }
        public static void Main()
        {
            Player getPlayer = new Player("Петя", 2, 5, 0);
            Items getItems = new Items(false,false,0);
            Map[,] getMap = new Map[10,10];

            Console.WriteLine();
        }
    }
}
