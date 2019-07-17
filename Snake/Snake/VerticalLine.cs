using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> VPoint;

        public VerticalLine(int x, int yUp, int yDown, char sym)
        {
            VPoint = new List<Point>();
            for (int i = yUp; i <= yDown; i ++)
            {
                Point _i = new Point(x, i, sym);
                VPoint.Add(_i);
            }
        }

        public void VDraw ()
        {
            foreach (Point i in VPoint)
            {
                i.Draw();
            }
        }
    }
}
