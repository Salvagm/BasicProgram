using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEX.DrawLib
{
    class Ellipse : BaseShape
    {
        public int DiameterH { get; set; }
        public int DiameterV { get; set; }

        public Ellipse() : base()
        {
            DiameterH = 0;
            DiameterV = 0;
        }

        public Ellipse(int xPosition, int yPosition, int diameterH, int diameterV) : base(xPosition,yPosition)
        {
            DiameterH = diameterH;
            DiameterV = diameterV;
        }


        public override void Print()
        {
            base.Print();
            //Specific draw fuction
        }
        public override string ToString()
        {
            return string.Format("{0}  diameterH = {1} diameterV = {2}", base.ToString(), DiameterH, DiameterV);
        }
    }
}
