using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Rect : Quadrilateral // inherits quad class
    {
        public int Area() // adds area method since not possible in quad
        {
            return LenSide1 * LenSide2;
        }
        public new void Print() // changes print to print both perimeter and area, new keyword is critical
        {
            Console.WriteLine($"Perimeter: {Perimeter()}, Area: {Area()}");
        }

        public Rect(int SideA, int SideB) : base(SideA, SideB, SideA, SideB) { } // calls quad constructor and assigns the two inputs from Rect to the four in quad

    }
}
