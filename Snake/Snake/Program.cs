using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(105, 30);
            HorizontalLine HLineUp = new HorizontalLine(1, 100, 0, '*');
            HLineUp.Drow();
            VerticalLine VLineLeft = new VerticalLine(1, 1, 28, '*');
            VLineLeft.Drow();
            HorizontalLine HLineDown = new HorizontalLine(2, 100, 28, '*');
            HLineDown.Drow();
            VerticalLine VLineRight = new VerticalLine(100, 1, 28, '*');
            VLineRight.Drow();

            Point tail = new Point(48, 14, '*');
            Snake snake = new Snake (tail, 5, Direction.RIGHT);
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
        }
    }
}
