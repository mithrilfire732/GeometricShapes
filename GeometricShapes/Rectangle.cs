using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Rect : Quadrilateral
    {
        public int Area()
        {
            return LenSide1 * LenSide2;
        }
        public new void Print()
        {
            Console.WriteLine($"Perimeter: {Perimeter()}, Area: {Area()}");
        }

        public Rect(int SideA, int SideB) : base(SideA, SideB, SideA, SideB) { }

    }
}
