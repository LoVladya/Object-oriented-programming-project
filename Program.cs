using System;
using System.Linq.Expressions;

namespace Object_oriented_programming_project
{
    internal class Program
    {
        class Player:Coordinates
        {
            private string name { get; set; }
            private int weaponLevel { get; set; } = 0;

            public Player(string Name, int X, int Y, int WeaponLevel):base(6,3)
            {
                this.name = Name;
                this.weaponLevel = WeaponLevel;
            }

        }

        class Coordinates
        {
            private int x;
            private int y;
            public Coordinates(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        class Items:Coordinates
        {

            private bool itemUpgrade;
            private bool armor;
            private int traps;
            public Items(bool itemUpgrade, bool armor, int traps):base(1,1) 
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
            Console.WriteLine("111");
        }
    }
}