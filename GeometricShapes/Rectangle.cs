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
        public Rect(int SideA, int SideB) : base(SideA, SideB, SideA, SideB) { }

    }
}
