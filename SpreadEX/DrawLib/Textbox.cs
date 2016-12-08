using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEX.DrawLib
{
    class Textbox : Rectangle
    {
        public string Text { get; set; }

        public Textbox() : base()
        {
            Text = "";
        }

        public Textbox(int xPosition, int yPosition, int width, int height, string text) : base(xPosition, yPosition, width, height)
        {
            Text = text;
        }

        public override void Print()
        {
            base.Print();
        }

        public override string ToString()
        {
            return string.Format("{0} Text=\"{1}\"", base.ToString(), Text);
        }
    }
}
