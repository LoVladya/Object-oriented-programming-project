using System;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading;

namespace Object_oriented_programming_project
{
    class Motor
    {
        Map fieldForPlayer = new Map();
        Player player = new Player("Vasya", 10);
        Inventory inventory = new Inventory();
        Maniac maniac = new Maniac("Petya", 20);
        SetElements input;
        Output output;
        public Motor()
        {
            input = new SetElements(fieldForPlayer);
            output = new Output();
        }

        public void GameProcess() // Запуск гри
        {
            bool gameFinish = false;
            input.SetElementsRandom(player, fieldForPlayer);
            input.SetElementsRandom(maniac, fieldForPlayer);
            output.PrintGameField(fieldForPlayer);
            output.PrintInfo(player, inventory, maniac);
            while (!gameFinish)
            {
                if (player.Health == 0 || maniac.Health == 0)
                {
                    break;
                }
                //Thread.Sleep(20); // Таймер, якщо гра працює без зупинки в очікуванні клавіши
                gameFinish = ProcessRun();
            }
        }

        private bool ProcessRun()
        {
            int setX = player.x, setY = player.y;
            if (!Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                fieldForPlayer[setX, setY] = new Emptiness();
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

                if (!fieldForPlayer[setX, setY].tryToGo)
                {
                    return false;
                }

                fieldForPlayer[setX, setY].Activity(player, inventory);
                player.x = setX;
                player.y = setY;
                fieldForPlayer[setX, setY] = player;
                output.PrintGameField(fieldForPlayer);
                output.PrintInfo(player, inventory, maniac);
            }
            return false;
        }
    }
}