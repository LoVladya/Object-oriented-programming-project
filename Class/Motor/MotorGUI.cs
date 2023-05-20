using Object_oriented_programming_project.GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Object_oriented_programming_project.Class.GUI
{
    internal class MotorGUI
    {
        public Map fieldForPlayer = new Map();
        Inventory inventory = new Inventory();
        Maniac maniac = new Maniac("Petya", 20);
        Element previousElement = new Emptiness();
        ManiacBrain maniacMove = new ManiacBrain();
        public MainForm mainForm;
        Player player;
        RandomSetter input;
        OutputGUI outputGUI;
        SettingsForm settingsForm;

        public MotorGUI()
        {
            player = new Player("Vasya", 10, inventory);
            settingsForm = new SettingsForm(ref fieldForPlayer.level);
            mainForm = new MainForm(settingsForm);
        }

        public void GameProcess(GameFieldForm gameFieldForm) // Запуск гри
        {
            fieldForPlayer.DictionarySizeSetter();
            fieldForPlayer.FieldGenerator();
            input = new RandomSetter(fieldForPlayer);
            outputGUI = new OutputGUI(gameFieldForm);
            input.SetElementsRandom(player, fieldForPlayer);
            input.SetElementsRandom(maniac, fieldForPlayer);
            outputGUI.SetPrintInfoAndField(player, maniac, fieldForPlayer.gameField);
        }
        public bool Step(GameFieldForm gameFieldForm, char keyChar)
        {
            int newX = player.x, newY = player.y;
            Dictionary<char, Action> movementKeys = new Dictionary<char, Action>()
            {
                { 'w', () => newX-- },
                { 's', () => newX++ },
                { 'a', () => newY-- },
                { 'd', () => newY++ },
                { '*', () => StepManiac() }
            };
            movementKeys[keyChar]();

            if (!fieldForPlayer[newX, newY].isWalkable)
            {
                return false;
            }

            fieldForPlayer[newX, newY].Actions(player);
            SetCoordinates();
            outputGUI.PrintInfo(player, maniac);

            if (player.Health < 1 || maniac.Health < 1)
            {
                return true;
            }
            return false;

            void SetCoordinates()
            {
                Dictionary<char, Action> visibleElements = new Dictionary<char, Action>()
                {
                    { '♥', () => outputGUI.lifePictureBox.Visible = false },
                    { '†', () => outputGUI.trapPictureBox.Visible = false },
                    { '1', () => outputGUI.armourOnePictureBox.Visible = false },
                    { '2', () => outputGUI.armourTwoPictureBox.Visible = false },
                    { '☺', () => { } },
                    { ' ', () => { } }
                };

                visibleElements[fieldForPlayer[newX, newY].symbol]();
                fieldForPlayer[player.x, player.y] = new Emptiness();
                player.x = newX;
                player.y = newY;
                fieldForPlayer[player.x, player.y] = player;
                outputGUI.playerPictureBox.Location = new Point(player.y * 28 + gameFieldForm.sizeForm, player.x * 28 + gameFieldForm.sizeForm);
                
            }

            void StepManiac()
            {
                if (new Random().Next(6) < 4)
                {
                    fieldForPlayer[maniac.x, maniac.y] = previousElement;
                    maniacMove.ManiacMove(fieldForPlayer.gameField, player, maniac);
                    previousElement = fieldForPlayer[maniac.x, maniac.y];
                    fieldForPlayer[maniac.x, maniac.y] = maniac;
                    outputGUI.maniacPictureBox.Location = new Point(maniac.y * 28 + gameFieldForm.sizeForm, maniac.x * 28 + gameFieldForm.sizeForm);
                }
            }
        }
    }
}
