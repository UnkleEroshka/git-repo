﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace April18
{
    class Figure
    {
       protected List<Point> pList;

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}