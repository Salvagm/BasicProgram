using System;
using System.Collections.Generic;

using SpreadEX.DrawLib;

namespace SpreadEX
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Widget> shapes = new List<Widget>();

            // Exercise
            try
            {
                shapes.Add(new Rectangle(xPosition: 10, yPosition: 10, width: 30, height: 40));
                shapes.Add(new Square(xPosition: 15, yPosition: 30,width: 35));
                shapes.Add(new Ellipse(xPosition: 100, yPosition: 150, diameterH : 300, diameterV: 200));
                shapes.Add(new Circle(xPosition: 1, yPosition: 1, diameter: 300));
                //shapes.Add(new Circle(xPosition: 1, yPosition: 1, diameter: -300));
                shapes.Add(new Textbox(xPosition: 5, yPosition: 5, width: 200, height: 100, text: "Sample text"));

            }catch(Exception ex)
            {
                Console.WriteLine("*************");
                Console.WriteLine(ex.Message);   
                Console.WriteLine("*************");
                Console.WriteLine(ex.StackTrace);
            }


            // Examples
            //shapes.Add(new Square(2, 2, 10));
            //shapes.Add(new Rectangle(3, 3, 10, 20));

            foreach (var shape in shapes)
            {
                shape.Print();
            }

            Console.ReadKey();

        }
    }
}
