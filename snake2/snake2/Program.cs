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
            Console.SetWindowSize(60, 25);
            Console.SetBufferSize(60, 25);
            Console.Title = "Snake";

            HLines uLine = new HLines(0, 58, 0,'*');
            HLines dLine = new HLines(0, 58, 24, '*');
            VLines lLine = new VLines(0, 24, 0,'*');
            VLines rLine = new VLines(0, 24, 58,'*');

            uLine.DrawLine();
            dLine.DrawLine();
            lLine.DrawLine();
            rLine.DrawLine();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.DrawLine();
            Console.Read();
        }

        
    }
}
