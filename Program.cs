using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;
using System.Threading;

namespace Object_oriented_programming_project
{
    internal class Program
    {
        class Player : Coordinates
        {

            private string name = "Player";
            private int health 
            {
                get;
                set;
            }
            private int weaponLevel;
            public int SetWeaponLevel
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
            public void TakeDamage(int value)
            {
                health += value;
            }
            public int GetHealth()
            {
                return health;
            }
            public Player(string name, int health) : base(3, 3)
            {
                this.name = name;
                this.health = health;
            }
        }
        class Maniac : Coordinates
        {
            private string name = "Маніяк";
            private int health = 30;
            public Maniac(int health) : base(7, 2)
            {
                this.health = health;
            }
            public int GetHealth()
            {
                return health;
            }
            public void SetHealth(int value)
            {
                health += value;
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
            private int traps;
            public Items(bool itemUpgrade, bool armor, int traps) : base(1, 1)
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
                gameField = new Elements[width, height];
                this.width = width;
                this.height = height;
                FieldFilling();
            }
            private void FieldFilling() // Наповнення масиву ігрового поля
            {
                Random random = new Random();
                for (int cellW = 0; cellW < width; cellW++)
                {
                    for (int cellH = 0; cellH < height; cellH++)
                    {
                        if (cellW == 0 || cellW == width - 1)
                            gameField[cellW, cellH] = new Wall();
                        else if (cellH == 0 || cellH == height - 1)
                            gameField[cellW, cellH] = new Wall();
                        else
                            gameField[cellW, cellH] = new Emptiness();
                    }
                }
                void SetElements(Elements elem)
                {
                    gameField[random.Next(1, width - 1), random.Next(1, height - 1)] = elem;
                }
                SetElements(new Lifes());
                SetElements(new Trap());
                SetElements(new ManiacElem());
            }
            public void PrintGameField() // Друк ігрового поля
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
                Console.WriteLine();
            }
        }
        class Elements
        {
            public char symbol;
            public bool tryToGo = true;
            public Elements(char symbol)
            {
                this.symbol = symbol;
            }
        }
        class Wall : Elements
        {
            public Wall() : base('#')
            {
                tryToGo = false;
            }
        }
        class PlayerElem : Elements
        {
            public PlayerElem() : base('☺')
            {
                tryToGo = true;
            }
        }
        class ManiacElem : Elements
        {
            public ManiacElem() : base('☼')//♦
            {
                tryToGo = true;
            }
        }
        class Emptiness : Elements
        {
            public Emptiness() : base(' ')
            {
                tryToGo = true;
            }
        }
        class Lifes : Elements
        {
            public Lifes() : base('♥')
            {
                tryToGo = true;
            }
        }
        class Trap : Elements
        {
            public Trap() : base('†')
            {
                tryToGo = true;
            }
        }
        class Motor 
        {
            Map fieldForPlayer = new Map(15, 25);
            Coordinates coordPlayer = new Coordinates(10,10);
            Player player = new Player("vasya", 10);
            Maniac maniac = new Maniac(30);
            public void GameProcess() // Запуск гри
            {
                bool gameFinish = false;
                
                fieldForPlayer.PrintGameField();
                while (!gameFinish)
                {
                    if(player.GetHealth() == 0 || maniac.GetHealth() == 0)
                    {
                        break;
                    }
                    Thread.Sleep(20);
                    gameFinish = ProcessRun();
                } 
            }
            private bool ProcessRun()
            {
                int setX = coordPlayer.x, setY = coordPlayer.y;
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    fieldForPlayer.gameField[setX, setY] = new Emptiness();
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                        case ConsoleKey.W:
                            setX--;
                            break;

                        case ConsoleKey.DownArrow:
                        case ConsoleKey.S:
                            setX++;
                            break;

                        case ConsoleKey.LeftArrow:
                        case ConsoleKey.A:
                            setY--;
                            break;

                        case ConsoleKey.RightArrow:
                        case ConsoleKey.D:
                            setY++;
                            break;

                        case ConsoleKey.Escape:
                            return true;
                    }
                    switch(fieldForPlayer.gameField[setX, setY].symbol)
                    {
                        case '♥':
                            player.TakeDamage(1); 
                            break;
                        case '†':
                            player.TakeDamage(-1);
                            break;
                    }
                    if (!fieldForPlayer.gameField[setX, setY].tryToGo)
                    {
                       return false;
                    }
                }
                coordPlayer.x = setX;
                coordPlayer.y = setY;
                fieldForPlayer.gameField[setX, setY] = new PlayerElem();
                fieldForPlayer.PrintGameField();
                Console.WriteLine("Кількість життів: "+player.GetHealth());
                return false;
            }
        }
        public static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Motor game = new Motor();
            game.GameProcess();
        }
    }
}