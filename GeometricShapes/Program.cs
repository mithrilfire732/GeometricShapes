using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Quadrilateral(4,6,5,8) {};
            var r1 = new Rect(3, 5) { };
            var s1 = new Square(5);
            q1.Print();
            r1.Print();
            s1.Print();
        }
    }
}
