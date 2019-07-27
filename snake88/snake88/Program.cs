using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake88
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();*/

            HorizontalLine line = new HorizontalLine(2, 120, 2, '+');
            line.Draw();

            VerticalLine vline = new VerticalLine(2, 30, 2, '+');
            vline.Draw();

            Console.ReadLine();

        }
    }
}
