using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
    internal class Walls
    {
        List<Figure> wallList;

        public Walls(int mWidht, int mHeight)
        {
            wallList = new List<Figure>();

            HLines uLine = new HLines(0, mWidht-2, 0, '#');
            HLines dLine = new HLines(0, mWidht-2, mHeight-1, '#');
            VLines lLine = new VLines(0, mHeight-1, 0, '#');
            VLines rLine = new VLines(0, mHeight-1, mWidht-2, '#');

            wallList.Add(uLine);
            wallList.Add(dLine);
            wallList.Add(lLine);
            wallList.Add(rLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
                
            }
            return false;
        }
        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.DrawLine();
            }
            
        }
    }
}
