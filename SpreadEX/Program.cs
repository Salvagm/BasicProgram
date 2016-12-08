using System;
using System.Collections.Generic;

using SpreadEX.DrawLib;

namespace SpreadEX
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<BaseShape> shapes = new List<BaseShape>();
            shapes.Add(new Square(2, 2, 10));
            shapes.Add(new Rectangle(3, 3, 10, 20));

            foreach (var shape in shapes)
            {
                shape.Print();
            }

            Console.ReadKey();

        }
    }
}
