using System;
using System.Collections.Generic;

using SpreadEX.DrawLib;

namespace SpreadEX
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseShape sq = new Square(2, 2, 10);

            sq.Print();

            Console.ReadKey();

        }
    }
}
