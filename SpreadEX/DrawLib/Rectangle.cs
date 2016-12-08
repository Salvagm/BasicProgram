using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEX.DrawLib
{
    class Rectangle : Widget
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle() : base()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(int xPosition, int yPosition, int width, int height) : base(xPosition,yPosition)
        {
            if(width >= 0 && height >= 0)
            {
                Width = width;
                Height = height;
            }
            else
            {
                throw new Exception("Width and Height must be positive ");
            }
        }

        public override void Print()
        {
            base.Print();
            //Specific draw fuction
        }


        public override string ToString()
        {
            return string.Format("{0} width={1} height={1}", base.ToString(), Width,Height);
        }

    }
}
