using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Threading;

namespace Object_oriented_programming_project
{
    internal class Program
    {
        class Player:Coordinates
        {
            private string Name;
            private int weaponLevel;
            public int WeaponLevel
            {
                get => weaponLevel;
                set
                {
                    if (value < 1)
                        weaponLevel = 1;
                    else
                        weaponLevel = value;
                }
            } 
            public Player(string name, int weaponLevel):base(6,3)
            {
                this.Name = name;
                this.weaponLevel = weaponLevel;
            }
        }
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
        class Items:Coordinates
        {
            private bool itemUpgrade;
            private bool armor;
            private int  traps;
            public Items(bool itemUpgrade, bool armor, int traps):base(1,1) 
            {

                this.itemUpgrade = itemUpgrade;
                this.armor = armor;
                this.traps = traps;
            }
        }
        class Map
        {
            public Elements[,] gameField;
            private int width;
            private int height;
            public Map(int width, int height)
            {
                this.gameField = new Elements[width, height];
                this.width = width;
                this.height = height;
                FieldFilling();
            }
            private void FieldFilling()
            {
                char[,] charField = new char[width, height];
                for (int cellW = 0; cellW < width; cellW++)
                {
                    for (int cellH = 0; cellH < height; cellH++) 
                    {
                        if (cellW == 0 || cellW == width-1)
                            gameField[cellW, cellH] = new Wall();
                        else if (cellH == 0 || cellH == height-1)
                            gameField[cellW, cellH] = new Wall();
                        else
                            gameField[cellW, cellH] = new Emptiness();
                    }
                }
            }
            public void PrintGameField()
            {
                Console.Clear();
                for (int i = 0; i < gameField.GetLength(0); i++)
                {
                    for (int j = 0; j < gameField.GetLength(1); j++)
                    {
                        Console.Write(gameField[i, j].symbol.ToString() + ' ');
                    }
                    Console.WriteLine();
                } 
            }
        }
        class Elements
        {
            public char symbol;
            public Elements(char symbol) 
            {
                this.symbol = symbol;
            }
        }
        class Wall:Elements
        {
            public Wall() : base('#') { }
        }
        class setPlayer : Elements
        {
            public setPlayer() : base('☺') { }
        }
        class Emptiness:Elements
        {
            public Emptiness() : base(' ') { }
        }
        class Motor
        {
            Map fieldForPlayer = new Map(15, 25);
            Coordinates coordPlayer = new Coordinates(10,10);
            public void GameProcess() 
            {
                bool gameFinish = false;
                fieldForPlayer.PrintGameField();
                gameFinish = ProcessRun();
                do 
                {
                    Thread.Sleep(20);
                    gameFinish = ProcessRun();
                } while(!gameFinish);
            }
            private bool ProcessRun()
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    fieldForPlayer.gameField[coordPlayer.x,coordPlayer.y] = new Emptiness();
                    
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                        case ConsoleKey.W:
                            coordPlayer.x--;
                            break;

                        case ConsoleKey.DownArrow:
                        case ConsoleKey.S:
                            coordPlayer.x++;
                            break;

                        case ConsoleKey.LeftArrow:
                        case ConsoleKey.A:
                            coordPlayer.y--;
                            break;

                        case ConsoleKey.RightArrow:
                        case ConsoleKey.D:
                            coordPlayer.y++;
                            break;

                        case ConsoleKey.Escape:
                            return true;
                    }
                }
                fieldForPlayer.gameField[coordPlayer.x, coordPlayer.y] = new setPlayer();
                fieldForPlayer.PrintGameField();
                return false;
            }
        }
        public static void Main()
        {
            Motor game = new Motor();
            game.GameProcess();
        }
    }
}