using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_3___Inheritance_and_Virtual
{
    public class Programmer : Employee1
    {
        //PROPERTIES
        public string ProgrammingLanguage { get; set; }


        //constructor
        public Programmer(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
