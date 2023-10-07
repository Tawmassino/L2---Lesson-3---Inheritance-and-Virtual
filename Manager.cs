using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_3___Inheritance_and_Virtual
{
    public class Manager : Employee1
    {
        //PROPERTIES
        public List<Employee1> Employees { get; set; } = new List<Employee1>(); // i lista isidedame parent klase 


        //constructor
        public Manager()
        {


        }

        public Manager(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        //METHOD


    }
}
