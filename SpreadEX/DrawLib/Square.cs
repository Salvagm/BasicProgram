using System;


namespace SpreadEX.DrawLib
{
    class Square : BaseShape
    {
        public int Size { get; set; }

        public Square() : base()
        {
            ShapeName = GetType().Name;
            Single = 0;
        }

        public Square(int xPosition, int yPosition, int size) : base(xPosition, yPosition)
        {
            ShapeName = GetType().Name;
            Size = size;
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return string.Format("{0} Size={1}",base.ToString(),Size);
        }
    }
}
