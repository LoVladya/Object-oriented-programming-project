using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Windows.Input;

namespace Object_oriented_programming_project
{
    class MotorConsole
    {
        Map fieldForPlayer = new Map();
        Inventory inventory = new Inventory();
        Element previousElement = new Emptiness();
        ManiacBrain maniacMove = new ManiacBrain();
        Maniac maniac = new Maniac("Petya", 20);
        Player player;
        RandomSetter input;
        OutputConsole output;
        
        public MotorConsole()
        {
            fieldForPlayer.SizeSetterConsole();
            fieldForPlayer.FieldGenerator();
            player = new Player("Vasya", 10, inventory);
            input = new RandomSetter(fieldForPlayer);
            output = new OutputConsole();
            input.SetElementsRandom(player, fieldForPlayer);
            input.SetElementsRandom(maniac, fieldForPlayer);
        }

        public void GameProcess() // Запуск гри
        {
            bool gameFinish = false;
            output.PrintInfoAndField(fieldForPlayer.gameField, player, inventory, maniac);
            while (!gameFinish)
            {
                if (player.Health == 0 || maniac.Health == 0)
                {
                    Console.WriteLine("Ви програли, нажаль :(");
                    break;
                }
                gameFinish = Step();
            }
        }
        private bool Step()
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            int newX = player.x, newY = player.y;
            if (key == ConsoleKey.Escape)
            {
                return true;
            }

            PlayerStep();

            if (!fieldForPlayer[newX, newY].isWalkable)
            {
                return false;
            }

            fieldForPlayer[newX, newY].Actions(player);
            SetCoordinates();
            output.PrintInfoAndField(fieldForPlayer.gameField, player, inventory, maniac);

            return false;

            void PlayerStep()
            {
                Dictionary<char, Action> movementKeys = new Dictionary<char, Action>()
                {
                    { 'W', () => newX-- },
                    { 'S', () => newX++ },
                    { 'A', () => newY-- },
                    { 'D', () => newY++ }
                };

                movementKeys[(char)key]();
            }
            void SetCoordinates()
            {
                fieldForPlayer[player.x, player.y] = new Emptiness();
                player.x = newX;
                player.y = newY;
                fieldForPlayer[player.x, player.y] = player;

                fieldForPlayer[maniac.x, maniac.y] = new Emptiness();
                fieldForPlayer[maniac.x, maniac.y] = previousElement;
                maniacMove.ManiacMove(fieldForPlayer.gameField, player, maniac);
                previousElement = fieldForPlayer[maniac.x, maniac.y];
                fieldForPlayer[maniac.x, maniac.y] = maniac;
            }
        }
    }
}