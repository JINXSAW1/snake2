using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
    internal class FoodCreator
    {
        int mWidth;
        int mHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mWidth, int mHeight, char sym)
        {
            this.mWidth = mWidth;
            this.mHeight = mHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(3, mWidth - 3);
            int y = random.Next(3, mHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
