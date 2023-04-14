using System;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading;

namespace Object_oriented_programming_project
{
        class Map
        {
            public Elements[,] gameField;
            Random random = new Random();
            private string level;
            private static int width;
            private static int height;
            public Map(string level)
            {
                this.level = level;
                FieldFilling();
            }
            private void FieldFilling() // Наповнення масиву ігрового поля
            {
                char[,] field;
                if (level == "easy")
                {
                    width = 10;
                    height = 15;
                    field = new char[10, 15] // easy
                    {
                    {'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w'},
                    {'w', ' ', ' ', ' ', ' ', 'w', ' ', ' ', ' ', 'w', ' ', ' ', ' ', ' ', 'w'},
                    {'w', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'w', ' ', ' ', 'w', 'w'},
                    {'w', ' ', ' ', 'w', ' ', ' ', ' ', ' ', 'w', ' ', ' ', ' ', ' ', ' ', 'w'},
                    {'w', ' ', 'w', 'w', ' ', ' ', 'w', ' ', ' ', ' ', ' ', 'w', ' ', ' ', 'w'},
                    {'w', ' ', ' ', 'w', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', ' ', ' ', 'w'},
                    {'w', 'w', ' ', ' ', 'w', ' ', 'w', 'w', 'w', 'w', ' ', ' ', 'w', 'w', 'w'},
                    {'w', ' ', 'w', ' ', 'w', ' ', ' ', ' ', 'w', ' ', ' ', 'w', 'w', ' ', 'w'},
                    {'w', ' ', ' ', ' ', ' ', ' ', 'w', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'w'},
                    {'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w'}
                    };
                }
                else if (level == "medium")
                {
                    width = 15;
                    height = 22;
                    field = new char[15, 22] // medium
                        {
                            {'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w'},
                            {'w', ' ', ' ', 'w', ' ', ' ', ' ', ' ', ' ', 'w', ' ', ' ', ' ', 'w', 'w', 'w', 'w', 'w', ' ', 'w', ' ', 'w'},
                            {'w', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', ' ', ' ', 'w', ' ', 'w', ' ', ' ', 'w', ' ', ' ', 'w', ' ', 'w'},
                            {'w', ' ', ' ', ' ', ' ', 'w', 'w', ' ', ' ', ' ', 'w', ' ', ' ', 'w', 'w', ' ', ' ', ' ', 'w', ' ', ' ', 'w'},
                            {'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'w', ' ', ' ', 'w', ' ', ' ', 'w', ' ', 'w', ' ', ' ', 'w', 'w'},
                            {'w', ' ', ' ', ' ', ' ', ' ', 'w', ' ', ' ', ' ', ' ', ' ', ' ', 'w', ' ', ' ', ' ', ' ', 'w', ' ', ' ', 'w'},
                            {'w', 'w', ' ', 'w', 'w', 'w', 'w', ' ', 'w', ' ', 'w', 'w', ' ', ' ', 'w', 'w', ' ', ' ', 'w', ' ', 'w', 'w'},
                            {'w', ' ', ' ', ' ', 'w', ' ', ' ', ' ', 'w', ' ', 'w', 'w', 'w', ' ', ' ', ' ', ' ', 'w', ' ', ' ', ' ', 'w'},
                            {'w', ' ', 'w', ' ', ' ', 'w', 'w', ' ', ' ', ' ', ' ', 'w', ' ', ' ', ' ', 'w', ' ', ' ', ' ', 'w', ' ', 'w'},
                            {'w', ' ', 'w', 'w', ' ', ' ', 'w', ' ', ' ', 'w', ' ', ' ', ' ', 'w', ' ', ' ', ' ', ' ', 'w', 'w', ' ', 'w'},
                            {'w', ' ', ' ', 'w', 'w', ' ', 'w', ' ', 'w', 'w', ' ', 'w', ' ', ' ', 'w', ' ', 'w', ' ', ' ', ' ', ' ', 'w'},
                            {'w', 'w', ' ', 'w', ' ', ' ', ' ', ' ', 'w', ' ', ' ', 'w', 'w', ' ', 'w', ' ', ' ', ' ', ' ', 'w', ' ', 'w'},
                            {'w', ' ', ' ', 'w', 'w', ' ', ' ', 'w', ' ', ' ', ' ', 'w', ' ', ' ', 'w', ' ', 'w', 'w', ' ', 'w', ' ', 'w'},
                            {'w', ' ', 'w', ' ', ' ', ' ', 'w', ' ', ' ', 'w', ' ', ' ', ' ', 'w', ' ', ' ', 'w', ' ', ' ', 'w', ' ', 'w'},
                            {'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w'}
                        };
                }
                else
                {
                    width = 20;
                    height = 30;
                    field = new char[20, 30] // hard
                        {
                            {'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w'},
                            {'w', ' ', ' ', ' ', 'w', ' ', ' ', ' ', 'w', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', ' ', ' ', ' ', 'w', 'w', 'w', ' ', 'w', ' ', ' ', ' ', ' ', 'w'},
                            {'w', ' ', 'w', ' ', ' ', ' ', 'w', ' ', 'w', ' ', ' ', ' ', ' ', 'w', ' ', 'w', 'w', 'w', 'w', ' ', ' ', 'w', ' ', ' ', ' ', ' ', 'w', ' ', 'w', 'w'},
                            {'w', 'w', 'w', 'w', ' ', 'w', 'w', ' ', 'w', ' ', 'w', 'w', ' ', ' ', ' ', 'w', 'w', ' ', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'w', ' ', ' ', 'w'},
                            {'w', ' ', 'w', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'w', ' ', ' ', ' ', 'w', ' ', ' ', ' ', 'w', ' ', ' ', 'w', 'w', ' ', ' ', 'w', ' ', 'w', ' ', 'w'},
                            {'w', ' ', 'w', ' ', ' ', 'w', ' ', 'w', ' ', 'w', 'w', ' ', 'w', 'w', ' ', ' ', 'w', ' ', 'w', ' ', 'w', 'w', ' ', 'w', ' ', ' ', ' ', 'w', ' ', 'w'},
                            {'w', ' ', ' ', 'w', ' ', 'w', ' ', ' ', 'w', ' ', ' ', ' ', 'w', ' ', ' ', 'w', 'w', ' ', 'w', ' ', ' ', ' ', ' ', ' ', 'w', ' ', 'w', 'w', 'w', 'w'},
                            {'w', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'w', ' ', ' ', ' ', 'w', 'w', ' ', ' ', ' ', ' ', 'w', ' ', 'w', ' ', ' ', ' ', ' ', 'w', ' ', 'w'},
                            {'w', ' ', ' ', ' ', ' ', ' ', ' ', 'w', ' ', ' ', ' ', ' ', 'w', 'w', ' ', 'w', ' ', 'w', 'w', 'w', 'w', ' ', 'w', ' ', ' ', 'w', ' ', 'w', ' ', 'w'},
                            {'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'w', 'w', 'w', 'w', ' ', ' ', 'w', ' ', 'w', ' ', 'w', ' ', ' ', 'w', 'w', ' ', 'w', ' ', ' ', ' ', 'w'},
                            {'w', 'w', 'w', ' ', 'w', ' ', ' ', ' ', ' ', ' ', 'w', ' ', ' ', ' ', 'w', ' ', 'w', 'w', ' ', ' ', ' ', 'w', ' ', ' ', ' ', 'w', 'w', ' ', 'w', 'w'},
                            {'w', ' ', ' ', ' ', 'w', 'w', ' ', 'w', ' ', ' ', 'w', ' ', 'w', 'w', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'w', ' ', 'w', 'w', ' ', 'w', ' ', ' ', 'w'},
                            {'w', 'w', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', ' ', ' ', ' ', ' ', 'w', ' ', ' ', ' ', 'w', ' ', ' ', 'w', ' ', 'w', ' ', ' ', ' ', ' ', ' ', 'w'},
                            {'w', ' ', ' ', ' ', 'w', ' ', 'w', ' ', ' ', ' ', 'w', ' ', ' ', 'w', 'w', 'w', ' ', 'w', ' ', ' ', ' ', ' ', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w'},
                            {'w', ' ', 'w', ' ', ' ', ' ', 'w', 'w', ' ', 'w', 'w', 'w', ' ', ' ', 'w', 'w', ' ', ' ', 'w', 'w', ' ', 'w', 'w', ' ', 'w', 'w', 'w', ' ', ' ', 'w'},
                            {'w', 'w', ' ', ' ', 'w', ' ', 'w', ' ', ' ', 'w', ' ', ' ', ' ', ' ', ' ', 'w', ' ', 'w', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'w', ' ', 'w', 'w'},
                            {'w', ' ', 'w', 'w', ' ', ' ', ' ', 'w', 'w', 'w', 'w', ' ', ' ', 'w', ' ', 'w', ' ', 'w', ' ', 'w', 'w', ' ', 'w', ' ', 'w', ' ', 'w', ' ', ' ', 'w'},
                            {'w', ' ', ' ', 'w', ' ', 'w', ' ', 'w', ' ', ' ', ' ', 'w', 'w', ' ', ' ', 'w', ' ', 'w', ' ', ' ', ' ', 'w', ' ', ' ', 'w', ' ', ' ', 'w', ' ', 'w'},
                            {'w', ' ', ' ', ' ', ' ', 'w', ' ', ' ', ' ', 'w', ' ', ' ', ' ', 'w', ' ', ' ', ' ', ' ', 'w', ' ', ' ', ' ', ' ', 'w', 'w', 'w', ' ', ' ', ' ', 'w'},
                            {'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w', 'w'}
                        };
                }
                gameField = new Elements[width, height];

                for (int cellW = 0; cellW < width; cellW++)
                {
                    for (int cellH = 0; cellH < height; cellH++)
                    {
                        switch (field[cellW, cellH])
                        {
                            case 'w':
                                gameField[cellW, cellH] = new Wall();
                                break;
                            case ' ':
                                gameField[cellW, cellH] = new Emptiness();
                                break;
                            /*
                            case '☼':
                                gameField[cellW, cellH] = new ManiacElem();
                                break;
                            case '♥':
                                gameField[cellW, cellH] = new Lifes();
                                break;
                            case '†':
                                gameField[cellW, cellH] = new Trap();
                                break;
                            case '1':
                                gameField[cellW, cellH] = new ArmourOne();
                                break;
                            case '2':
                                gameField[cellW, cellH] = new ArmourTwo();
                                break;*/
                    }
                }
                }
                void SetElementsRandom(Elements elem)
                {
                    int x;
                    int y;
                    while (true) 
                    {
                        x = random.Next(1, width - 1);
                        y = random.Next(1, height - 1);
                        if (gameField[x, y].tryToGo)
                        {
                            break; 
                        }
                    }
                    gameField[x, y] = elem;
                }
                SetElementsRandom(new Lifes());
                SetElementsRandom(new Trap());
                SetElementsRandom(new ManiacElem());
                SetElementsRandom(new ArmourOne());
                SetElementsRandom(new ArmourTwo());
            }
            public void PrintGameField() // Друк ігрового поля
            {
                Console.Clear();
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        Console.Write(gameField[i, j].symbol.ToString() + ' ');
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    
}