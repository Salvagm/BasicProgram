using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadEX.DrawLib
{
    class Widget
    {
        public Coordinates ShapePosition { get; set; }
        public string WidgetName { get; set; }

        public Widget(Coordinates position, string name)
        {
            ShapePosition = position;
            WidgetName = name;
        }
        public Widget()
        {
            ShapePosition = new Coordinates();
            WidgetName = GetType().Name;
        }

        public Widget(int xPosition, int yPosition)
        {
            ShapePosition = new Coordinates(xPosition, yPosition);
            WidgetName = GetType().Name;
        }

        public Widget(Widget other)
        {
            ShapePosition = new Coordinates(other.ShapePosition);
            WidgetName = other.WidgetName;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}",WidgetName, ShapePosition.ToString());
        }

        public virtual void Print()
        {
            System.Console.WriteLine(ToString());
        }
    }
}
