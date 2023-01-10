    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake2
{
    internal class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            PList=new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                PList.Add(p);
            }    
        }

        internal bool Eat(Point food)
        {
            Point head = GetNewPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                PList.Add(food);
                return true;
            }
            else
            {
                return false;   
            }
        }

        internal void Move()
        {
            Point tail = PList.First();
            PList.Remove(tail);
            Point Head = GetNewPoint();
            PList.Add(Head);

            tail.Clear();
            Head.Draw();
        }

        public Point GetNewPoint()
        {
            Point Head = PList.Last();
            Point NextPoint = new Point(Head);
            NextPoint.Move(1, direction);
            return NextPoint;
        }

        public void UsedKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
        }
    }
}
