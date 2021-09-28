using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Rectangle
    {
        public int LenS1 { get; set; }
        public int LenS2 { get; set; }


        public int Perimeter()
        {
            return LenS1 * 2 + LenS2 * 2;
        }
        public int Area()
        {
            return LenS1 * LenS2;
        }
    }
}
