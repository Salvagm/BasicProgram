using System;


namespace SpreadEX.DrawLib
{
    class Square : BaseShape
    {
        public int Size { get; set; }

        public Square() : base()
        {
            Size = 0;
        }

        public Square(int xPosition, int yPosition, int size) : base(xPosition, yPosition)
        {
            Size = size;
        }

        public override void Print()
        {
            base.Print();
            //Specific draw fuction
        }

        public override string ToString()
        {
            return string.Format("{0} Size={1}",base.ToString(),Size);
        }
    }
}
