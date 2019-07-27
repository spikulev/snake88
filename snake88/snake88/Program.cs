﻿using System;
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
            Console.SetBufferSize(87, 27);
          
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.DOWN);
            snake.Draw();

            Console.ReadLine();
        }
    }
}
