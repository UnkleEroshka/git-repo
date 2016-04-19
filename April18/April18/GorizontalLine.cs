using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace April18
{
    class GorizontalLine : Figure
    {
        
        public GorizontalLine(int xLeft, int xRight,int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xLeft;x<= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
            

        }
        
    }
}
