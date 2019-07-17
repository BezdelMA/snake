using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> HPoint;

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            HPoint = new List<Point>();
            for (int i = xLeft; i <= xRight; i++)
            {
                Point _i = new Point(i, y, sym);
                HPoint.Add(_i);
            }
        }

        public void HDraw()
        {
            foreach(Point i in HPoint)
            {
                i.Draw();
            }
        }

    }
}
