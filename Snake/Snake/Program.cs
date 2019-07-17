using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine HLineUp = new HorizontalLine(1, 100, 0, '_');
            HLineUp.HDraw();

            VerticalLine VLineLeft = new VerticalLine(1, 1, 28, '|');
            VLineLeft.VDraw();

            HorizontalLine HLineDown = new HorizontalLine(2, 100, 28, '_');
            HLineDown.HDraw();

            VerticalLine VLineRight = new VerticalLine(100, 1, 28, '|');
            VLineRight.VDraw();

            Console.ReadLine();
        }
    }
}
