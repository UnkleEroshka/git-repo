﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace April18
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 5;
            p1.y = 3;
            p1.sym = '*';

            p1.Draw();
           

            Console.ReadLine();
        }

       

    }
}
