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


            foreach (var shape in shapes)
            {
                shape.Print();
            }

            Console.ReadKey();

        }
    }
}
