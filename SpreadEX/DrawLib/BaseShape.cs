using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEX.DrawLib
{
    abstract class BaseShape
    {
        Coordinates ShapePosition;



        public BaseShape(Coordinates position)
        {
            ShapePosition = position;
        }

        public BaseShape(int xPosition, int yPosition)
        {
            ShapePosition = new Coordinates(xPosition, yPosition);
        }

        public BaseShape(BaseShape other)
        {
            ShapePosition = new Coordinates(other.ShapePosition);
        }

        public abstract void Print();
    }
}
