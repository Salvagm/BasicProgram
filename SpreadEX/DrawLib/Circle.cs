using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEX.DrawLib
{
    class Circle : BaseShape
    {
        public int Size { get; set; }

        public Circle() : base()
        {
            Size = 0;
        }

        public Circle(int xPosition, int yPosition, int size) : base(xPosition, yPosition)
        {
            Size = size;
        }

        public override void Print()
        {
            base.Print();
        }

        public override string ToString()
        {
            return string.Format("{0} Size={1}",base.ToString(),Size);
        }

    }
}
