using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEX.DrawLib
{
    /// <summary>
    /// Basic coordinates class
    /// </summary>
    class Coordinates
    {
        public float X
        {
            get; set;
        }

        public float Y
        {
            get; set;
        }

        public Coordinates(float x, float y)
        {
            X = x;
            Y = y;
        }

        public Coordinates(Coordinates other)
        {
            X = other.X;
            Y = other.Y;
        }
    }
}
