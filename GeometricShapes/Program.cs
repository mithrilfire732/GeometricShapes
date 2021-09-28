﻿using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Quadrilateral()
            {
                LenSide1 = 3,
                LenSide2 = 4,
                LenSide3 = 5,
                LenSide4 = 6
            };
            Console.WriteLine($"{q1.Perimeter()}");
            var r1 = new Rectangle()
            {
                LenS1 = 3,
                LenS2 = 5
            };
            Console.WriteLine($"{r1.Perimeter()}");
            Console.WriteLine($"{r1.Area()}");

            var s1 = new Square()
            {
                Side = 3
            };
            Console.WriteLine($"{s1.Perimeter()}");
            Console.WriteLine($"{s1.Area()}");
        }
    }
}