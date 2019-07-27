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
            Console.SetBufferSize(200, 49);
          
            HorizontalLine upline = new HorizontalLine(0, 120, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 120, 30, '+');
            VerticalLine leftline = new VerticalLine(0, 30, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 30, 120, '+');
            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();

            Point p = new Point(4, 5, '*');
            p.Draw();

            Employee e = new Employee();
            e.age = 30;
            e.salary = 0;

            Console.ReadLine();
        }
    }
}
