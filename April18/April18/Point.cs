﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace April18
{
    class Point
    {
        public int x;
        public int y;
        public char sym;


        public void Draw()
        {


            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);

        }
    }
}