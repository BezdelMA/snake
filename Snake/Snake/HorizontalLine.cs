﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int i = xLeft; i <= xRight; i++)
            {
                Point _i = new Point(i, y, sym);
                pList.Add(_i);
            }
        }
    }
}
