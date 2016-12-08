using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEX.DrawLib
{
    class Circle : Widget
    {
        public int Diameter { get; set; }

        public Circle() : base()
        {
            Diameter = 0;
        }

        public Circle(int xPosition, int yPosition, int size) : base(xPosition, yPosition)
        {
            Diameter = size;
        }

        public override void Print()
        {
            base.Print();
            //Specific draw fuction
        }

        public override string ToString()
        {
            return string.Format("{0} Size={1}",base.ToString(),Diameter);
        }

    }
}
