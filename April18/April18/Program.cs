using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace April18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);


            GorizontalLine gLineDown = new GorizontalLine(1, 70, 22, '*');
            
            GorizontalLine gLineUp = new GorizontalLine(1,70,2,'*');

            VerticalLine vLineL = new VerticalLine(2, 22, 1, '*');

            VerticalLine vLineR = new VerticalLine(2, 22, 71, '*');

            gLineUp.Drow();

            vLineR.Drow();

            vLineL.Drow();

            gLineDown.Drow();
            
            
            Console.ReadLine();
        }

       

    }
}
