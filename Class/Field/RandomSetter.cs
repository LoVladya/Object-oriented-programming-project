using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    internal class RandomSetter
    {
        Random random = new Random();
        Element[] elements = new Element[]
        {
            new Life(), new Trap(), new ArmourOne(), new ArmourTwo()
        };

        public RandomSetter(Map map)
        {
            FillingElements(map);
        }

        public void SetElementsRandom(Element elem, Map map)
        {
            int x, y;
            do
            {
                x = random.Next(1, map.width - 1);
                y = random.Next(1, map.height - 1);
            } while (map[x, y].isWalkable);

            elem.x = x;
            elem.y = y;
            map[x, y] = elem;
        }
        private void FillingElements(Map map)
        {
            foreach (Element num in elements)
            {
                SetElementsRandom(num, map);
            }
        }
    }
}
