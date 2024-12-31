using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session_1
{
    internal struct Point
    {
        public int X;
        public int Y;
        //constructor
        public Point()
        {
            X =20;
            Y = 99;
        }
        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }
    }
}
