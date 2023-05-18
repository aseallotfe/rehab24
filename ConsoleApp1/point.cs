using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class point
    {
        private double x;
        private double y;
        public point(double x,double y)
        {
            this.x = x;
            this.y = y;

        }
        public void move(double x, double y)
        {
            x = x - 5;
            y = y + 5;
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
        }
        public void Quadrant(double x,double y)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("first quarter");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("second quarter");
            }
            else if(x<0&&y<0)
            {
                Console.WriteLine("third quarter");
            }
            else
            {
                Console.WriteLine("four quarter");
            }
        }
        public void print(double x,double y)
        {
            Console.WriteLine("(" + x + "," + y + ")");
        }

    }
}
