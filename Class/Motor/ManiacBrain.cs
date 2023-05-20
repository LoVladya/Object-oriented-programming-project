using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Object_oriented_programming_project
{
    internal class ManiacBrain
    {
        const int emptiness = 0;
        const int barrier = 1;
        const int playerElem = 2;
        const int maniacElem = 3;
        Point[] neighboringСells = new Point[] { new Point(1, 0), new Point(-1, 0), new Point(0, 1), new Point(0, -1) };
        public void ManiacMove(Element[,] filledField, Player player, Maniac maniac)
        {
            int step = 3;
            int width = filledField.GetLength(0);
            int height = filledField.GetLength(1);

            int[,] maniacField = new int[width, height];

            for (int x = 0; x < width; x++) // створення додаткового поля
            {
                for (int y = 0; y < height; y++)
                {
                    if (filledField[x, y].isWalkable == false)
                    {
                        maniacField[x, y] = barrier;
                        continue;
                    }
                    maniacField[x, y] = emptiness;
                }
            }
            maniacField[maniac.x, maniac.y] = maniacElem;
            maniacField[player.x, player.y] = playerElem;

            Step();

            void Step() // хід маніяка
            {
                Queue<Point> queue = new Queue<Point>();
                queue.Enqueue(new Point(maniac.x, maniac.y));

                foreach (Point neighboringCell in neighboringСells)
                {
                    int neighboringX = maniac.x + (int)neighboringCell.X;
                    int neighboringY = maniac.y + (int)neighboringCell.Y;
                    if (maniacField[neighboringX, neighboringY] == playerElem)
                    {
                        player.Health = -1;
                        return;
                    }
                }

                while (queue.Count > 0)
                {
                    int count = queue.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Point current = queue.Dequeue();
                        int x = (int)current.X;
                        int y = (int)current.Y;

                        foreach (Point neighboringCell in neighboringСells)
                        {
                            int neighboringX = x + (int)neighboringCell.X;
                            int neighboringY = y + (int)neighboringCell.Y;
                            if (maniacField[neighboringX, neighboringY] == emptiness)
                            {
                                maniacField[neighboringX, neighboringY] = step + 1;
                                queue.Enqueue(new Point(neighboringX, neighboringY));
                                if (SearchPlayer(neighboringX, neighboringY))
                                {
                                    return;
                                }
                            }
                        }
                    }
                    step++;
                }
            }

            bool SearchPlayer(int x, int y) // пошук гравця
            {
                foreach (Point neighboringCell in neighboringСells)
                {
                    int neighboringX = x + (int)neighboringCell.X;
                    int neighboringY = y + (int)neighboringCell.Y;
                    if (maniacField[neighboringX, neighboringY] == playerElem)
                    {
                        ReverseMove(x, y);
                        return true;
                    }
                }
                return false;
            };

            void ReverseMove(int x, int y) // зворотній хід (найкоротший шлях)
            {
                if(step == 3) // Мінусуємо життя якщо маніяк поруч
                {
                    player.Health = -1;
                }
                for (step++; step > 3; step--)
                {
                    foreach (Point neighboringCell in neighboringСells)
                    {
                        int neighboringX = x + (int)neighboringCell.X;
                        int neighboringY = y + (int)neighboringCell.Y;
                        if (maniacField[neighboringX, neighboringY] == step)
                        {
                            x = neighboringX;
                            y = neighboringY;
                        }
                    }
                }
                maniac.x = x;
                maniac.y = y;
            };
        }
    }
}