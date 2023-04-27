using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_programming_project
{
    internal class SetElements
    {
        Random random = new Random();

        public SetElements(Map map)
        {
            FillingElements(map);
        }
        public void SetElementsRandom(Elements elem, Map map)
        {
            int x;
            int y;
            while (true)
            {
                x = random.Next(1, map.width - 1);
                y = random.Next(1, map.height - 1);
                if (map[x, y].tryToGo)
                {
                    break;
                }
            }
            elem.x = x;
            elem.y = y;
            map[x, y] = elem;
        }

        Elements[] elements = new Elements[]
        {
            new Lifes(), new Trap(), new ArmourOne(), new ArmourTwo()
        };
        private void FillingElements(Map map)
        {
            foreach (Elements num in elements)
            {
                SetElementsRandom(num, map);
            }
        }
    }
}
