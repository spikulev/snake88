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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Console.WriteLine();

            List<int> numList = new List<int>
            {
                3,
                6,
                9
            };

            int x = numList[ 0 ];
            int y = numList[ 1 ];
            int z = numList[ 2 ];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pointlist = new List<Point>()
            {
                p1,
                p2
            };
            
            Console.ReadLine();

        }
    }
}
