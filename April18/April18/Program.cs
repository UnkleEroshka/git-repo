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
            Point p1 = new Point(1,2,'*');
            Point p2 = new Point(5, 5, '#');
            p1.Draw();
            

            List<char> numPoint = new List<char>();
            numPoint.Add('#');
            numPoint.Add('*');
            foreach(int i in numPoint)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

       

    }
}
