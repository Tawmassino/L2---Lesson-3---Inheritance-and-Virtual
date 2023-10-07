using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_3___Inheritance_and_Virtual
{
    internal class Square : Polygon // Square PAVELDI IS Polygon klases
    {

        public double Size { get; set; }


        public Square()
        {

            NumberOfAngles = 0;

        }

        public Square(double size)
        {
            Size = size;
            NumberOfAngles = 4;
        }

        public override double GetPerimeter()
        {
            return Size * NumberOfAngles;
        }
    }
}
