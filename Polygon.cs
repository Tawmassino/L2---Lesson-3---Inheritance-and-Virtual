using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_3___Inheritance_and_Virtual
{
    public class Polygon
    {

        public int NumberOfAngles { get; set; }

        public Polygon()
        {

        }

        public Polygon(int numberOfAngles)
        {
            NumberOfAngles = numberOfAngles;
        }

        public virtual double GetPerimeter()
        {
            return 0;
        }
    }
}
