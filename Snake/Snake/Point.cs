using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point (int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point (Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move (int p, Direction direction)
        {
            if (direction == Direction.RIGHT)
                x += p;

            else if (direction == Direction.LEFT)
                x -= p;

            else if (direction == Direction.UP)
                y -= p;

            else if (direction == Direction.DOWN)
                y += p;
        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
