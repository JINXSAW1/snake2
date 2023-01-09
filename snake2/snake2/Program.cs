using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
    internal class Program
    {
        static void Main(string[] args)
            {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            HLines Line = new HLines(5, 10, 3,'+');
            Line.DrawHLine();


            Console.ReadLine();
        }

        
    }
}
