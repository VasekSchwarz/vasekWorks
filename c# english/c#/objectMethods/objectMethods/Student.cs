using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectMethods
{
    internal class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string Aname, string aMajor, double aGpa) 
        {
            name = Aname;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHoners() 
        {
            if(gpa >= 3.5) 
            {
                return true;
            }
            return false;
        }
    }
}
