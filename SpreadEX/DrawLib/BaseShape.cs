using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEX.DrawLib
{
    class BaseShape
    {
        public Coordinates ShapePosition { get; set; }
        public string ShapeName { get; set; }

        public BaseShape(Coordinates position, string name)
        {
            ShapePosition = position;
            ShapeName = name;
        }
        public BaseShape()
        {
            ShapePosition = new Coordinates();
            ShapeName = "dot";
        }

        public BaseShape(int xPosition, int yPosition)
        {
            ShapePosition = new Coordinates(xPosition, yPosition);
            ShapeName = "dot";
        }

        public BaseShape(BaseShape other)
        {
            ShapePosition = new Coordinates(other.ShapePosition);
            ShapeName = other.ShapeName;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}",ShapeName, ShapePosition.ToString());
        }

        public virtual void Print()
        {
            System.Console.WriteLine(ToString());
        }
    }
}
