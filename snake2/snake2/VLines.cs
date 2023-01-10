using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
    internal class VLines: Figure
    {

        public VLines(int yUp,int yDown,int x,char sym)
        {
            PList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                PList.Add(p);
            }
        }
    }
}
