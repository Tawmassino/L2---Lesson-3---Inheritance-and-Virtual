using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_3___Inheritance_and_Virtual
{
    public class Employee1
    {
        //PROPERTIES
        public string Name { get; set; }//turi buti public
        public double Salary { get; set; }

        //CONSTRUCTOR

        public Employee1()
        {

        }

        public Employee1(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        //METHOD
    }
}
