using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake (Point tail, int length, Direction direction)
        {
            this.direction = direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First<Point>();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last<Point>();
            Point _head = new Point(head);
            _head.Move(1, direction);
            return _head;
        }

        internal void turn(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key.Key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key.Key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            else if (key.Key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
        }
    }
}
