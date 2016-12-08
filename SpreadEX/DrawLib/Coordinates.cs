using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEX.DrawLib
{
    class Coordinates
    {
        public int X
        {
            get; set;
        }

        public int Y
        {
            get; set;
        }

        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Coordinates()
        {
            X = 0;
            Y = 0;
        }

        public Coordinates(Coordinates other)
        {
            X = other.X;
            Y = other.Y;
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }
    }
}
