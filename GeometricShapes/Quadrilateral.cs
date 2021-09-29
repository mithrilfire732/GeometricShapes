using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Quadrilateral
    {
        public int LenSide1 { get; set; }
        public int LenSide2 { get; set; }
        public int LenSide3 { get; set; }
        public int LenSide4 { get; set; }


        public int Perimeter()
        {
            return LenSide1 + LenSide2 + LenSide3 + LenSide4;
        }
        public void Print()
        {
            Console.WriteLine($"Perimeter: {Perimeter()}");
        }
        public Quadrilateral(int SideA, int SideB, int SideC, int SideD)
        {
            LenSide1 = SideA;
            LenSide2 = SideB;
            LenSide3 = SideC;
            LenSide4 = SideD;
        }
    }
}
