using System;


namespace SpreadEX.DrawLib
{
    class Square : Widget
    {
        public int Width { get; set; }

        public Square() : base()
        {
            Width = 0;
        }

        public Square(int xPosition, int yPosition, int width) : base(xPosition, yPosition)
        {
            if (width >= 0)
                Width = width;
            else
                throw new Exception("Width must be positive");
        }

        public override void Print()
        {
            base.Print();
            //Specific draw fuction
        }

        public override string ToString()
        {
            return string.Format("{0} Size={1}",base.ToString(),Width);
        }
    }
}
