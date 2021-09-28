﻿using System;
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
    }
}