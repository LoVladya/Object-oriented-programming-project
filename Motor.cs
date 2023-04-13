using System;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading;

namespace Object_oriented_programming_project
{
    
        class Motor
        {
            static private string level = "easy";
            public void SizeField() 
            {
                Console.WriteLine("Натисніть клавішу для вибору складності: e - easy, m - medium, h - HARD");
                if (!Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyLevel = Console.ReadKey(true);
                    switch (keyLevel.Key)
                    {
                        case ConsoleKey.E:
                            level = "easy";
                            break;

                        case ConsoleKey.M:
                            level = "medium";
                            break;

                        case ConsoleKey.H:
                            level = "hard";
                            break;
                    }
                    fieldForPlayer = new Map(level); 
                }
            }
            Map fieldForPlayer;
            Coordinates coordPlayer = new Coordinates(1, 1);
            Maniac maniac = new Maniac(30);
            
            public void GameProcess() // Запуск гри
            {
                bool gameFinish = false;
                SizeField();
                fieldForPlayer.PrintGameField();
            while (!gameFinish)
                {
                    if (Player.Health == 0 || Maniac.Health == 0)
                    {
                        break;
                    }
                    //Thread.Sleep(20); // Таймер, якщо гра працює без зупинки в очікуванні клавіши
                    gameFinish = ProcessRun();
                }
            }
            public void PrintInfo()
            {
                Console.WriteLine("Кількість життів: " + Player.Health);
                Console.WriteLine("Кількість броні: " + Inventory.Armour);
            }
            private bool ProcessRun()
            {
                int setX = coordPlayer.x, setY = coordPlayer.y;
                if (!Console.KeyAvailable)
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
                    
                    if (!fieldForPlayer.gameField[setX, setY].tryToGo)
                    {
                        return false;
                    }
                    fieldForPlayer.gameField[setX, setY].Activity();
                }
                coordPlayer.x = setX;
                coordPlayer.y = setY;
                fieldForPlayer.gameField[setX, setY] = new PlayerElem();
                fieldForPlayer.PrintGameField();
                PrintInfo();
                return false;
            }
        }
    
}