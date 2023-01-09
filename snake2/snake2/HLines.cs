using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
    internal class HLines
    {
        

        public HLines (int xLeft,int xRight, int y,char sym)
        {
            PList = new List<Point> ();
            for (int x = xLeft; x<= xRight; x++)
            {
                Point p = new Point(x,y,sym);
                PList.Add (p);
            }
        }

        public void DrawHLine()
        {
            foreach (Point p in PList)
            {
                p.Draw();
            }
        }
    }
}
