using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading;

namespace Object_oriented_programming_project
{
    internal class Map : MapDifficulty
    {
        public Element[,] gameField;
        public TextReader reader;

        public string level = "easy";
        public int width = 11;
        public int height = 15;

        public void DictionarySizeSetter() 
        {
            Dictionary<string, Action> levels = new Dictionary<string, Action>()
            {
                {"easy", () => {width = 11; height = 15;} },
                {"medium", () => {width = 15; height = 23;} },
                {"hard", () => {width = 21; height = 31;} }
            };
            levels[level]();
        }
        public void SizeSetterConsole()
        {
            LevelSetter();
            reader = new StreamReader(@"settings.txt");
            level = reader.ReadLine();
            reader.Close();
            DictionarySizeSetter();
            
        }
        public delegate void SetElement(int x, int y, int elem);

        public void FieldGenerator()
        {
            Random random = new Random();
            int[,] field = new int[width, height];
            gameField = new Element[width, height];

            int randomNumber;
            int maxIndex = 3;
            const int wall = 1;
            const int emptiness = 0;

            for (int y = 0; y < height; y++) // створення верхньої/нижньої границі
            {
                field[0, y] = wall;
                field[width - 1, y] = wall;
            }
            for (int x = 0; x < width; x++) // створення лівої/правої границі
            {
                field[x, 0] = wall;
                field[x, height - 1] = wall;
            }

            for (int x = 1; x < width - 3; x += 2) // створення перешкод
            {
                for (int y = 2; y < height - 1; y += 2)
                {
                    randomNumber = random.Next(3);
                    if (randomNumber > 0)
                    {
                        field[x, y] = wall;
                    }
                    else
                    {
                        MergeSets(x, y);
                    }
                }
            }

            for (int y = 1; y < height - 1; y += 2) // створення нижніх стінок перед границею
            {
                randomNumber = random.Next(2);
                if (randomNumber == 1 && field[width - 3, y] == wall)
                {
                    field[width - 3, y] = emptiness;
                    field[width - 2, y] = wall;
                }
            }

            for (int x = 0; x < width; x++) // Переведення з масиву int в масив об'єктів
            {
                for (int y = 0; y < height; y++)
                {
                    if (field[x, y] == wall)
                    {
                        gameField[x, y] = new Wall();
                    }
                    else
                    {
                        gameField[x, y] = new Emptiness();
                    }
                }
            }

            void MergeSets(int x, int y) // Об'єднання комірок якщо це одна множина
            {
                field[x, y + 1] = field[x, y - 1];
                field[x, y] = emptiness;
                field[x + 1, y + 1] = wall;
                maxIndex++;
                field[x + 2, y + 1] = maxIndex;
                if (field[x + 1, y - 1] != wall)
                {
                    field[x + 2, y - 1] = field[x, y - 1];
                }
            }
        }

        public Element this[int x, int y] // Індексатор
        {
            get { return gameField[x, y]; }
            set { gameField[x, y] = value; }
        }
    }
}
